using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVSEvent
{
    /// <summary>
    /// 自訂一個事件參數類別
    /// </summary>
    public class EventArgsSample : EventArgs
    {
        private string _message;

        /// <summary>
        /// 建構式
        /// </summary>
        public EventArgsSample()
        {
            this._message = string.Empty;
        }

        /// <summary>
        /// 建構式傳入訊息
        /// </summary>
        /// <param name="message">訊息</param>
        public EventArgsSample(string message)
        {
            this._message = message;
        }

        /// <summary>
        /// 訊息唯讀
        /// </summary>
        public string Message 
        {
            get { return _message; }
        }        
    }

    /// <summary>
    /// 管理主控台，在輸出前發送輸出事件
    /// </summary>
    public class ConsoleManager 
    {
        // 定義事件成員物件
        public event EventHandler<EventArgsSample> ConsoleEvent;

        /// <summary>
        /// 輸出
        /// </summary>
        /// <param name="message">用來傳給事件的訊息參數</param>
        public void ConsoleOutput(string message) 
        {
            //建立自訂事件參數類別
            EventArgsSample args = new EventArgsSample(message);

            // 呼叫發送事件Method
            // 傳入自訂事件參數
            SendConsoleEvent(args);
        }

        /// <summary>
        /// 負責發送事件
        /// </summary>
        /// <param name="args">事件參數</param>
        protected virtual void SendConsoleEvent(EventArgsSample args)
        {
            // 方法一: 呼叫定義事件成員物件
            // ConsoleEvent(this, args);
        
            // 方法二: 定義一個臨時的參考變數，這樣可以確保多執行緒呼叫時不會發生問題            
            EventHandler<EventArgsSample> temp = ConsoleEvent;
            if (temp != null)
            {
                temp(this, args);
            }
        }
    }

    /// <summary>
    /// 訂閱控制台輸出事件
    /// </summary>
    public class Log
    {        
        public Log(ConsoleManager manager)
        {
            // 訂閱控制台輸出事件
            // 使用方法跟委派一樣，加入方法
            manager.ConsoleEvent += Output;
        }

        /// <summary>
        /// 事件處理方法，輸出訊息
        /// </summary>
        /// <param name="send">事件發送者(ConsoleManager)</param>
        /// <param name="args">自訂事件參數(EventArgsSample)</param>
        private void Output(object send, EventArgs args) 
        {
            string message = ((EventArgsSample)args).Message;
            Console.WriteLine("事件處理方法:" + message);
        }
    }
}
