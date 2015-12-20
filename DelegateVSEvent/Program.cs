using System;

namespace DelegateVSEvent
{
    class Program
    {

        static void Main(string[] args)
        {
            // 建立主控台，等待被其他類別訂閱
            ConsoleManager cm = new ConsoleManager();
            
            // Log 類別，訂閱事件
            // 此時會將Log類別的private void Output方法，加到ConsoleManager類別的ConsoleEvent事件物件
            Log log = new Log(cm);            
            
            // 事件訂閱完成

            // 程式步驟說明
            // 1.cm.ConsoleOutput只有負責做SendConsoleEvent這個方法 (發送事件)
            // 2.SendConsoleEvent 負責執行事件成員物件 EventHandler<EventArgsSample> ConsoleEvent;
            // 3.因為剛剛Log類別，已在 ConsoleEvent 加上 Log 類別的Output方法
            // 4.所以當cm.ConsoleOutput 執行的時候，會去執行Log類別的Output方法
            // 5.並且輸出 訊息
            cm.ConsoleOutput("Hello"); // Output:事件處理方法:Hello
            cm.ConsoleOutput("World"); // Output:事件處理方法:World
            
        }

    }
}