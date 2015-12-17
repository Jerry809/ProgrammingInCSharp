namespace ClassAndStruct
{
    using System;

    /// <summary>
    /// 結構
    /// </summary>
    public struct TheStruct
    {
        public int x;
    }

    /// <summary>
    /// 類別
    /// </summary>
    public class TheClass
    {
        public int x;
    }

    internal class Program
    {
        /// <summary>
        /// 改變傳遞過來結構的值
        /// </summary>
        /// <param name="s">傳遞結構</param>
        private static void StructTaker(TheStruct s)
        {
            s.x = 5;
        }

        /// <summary>
        /// 改變傳遞過來類別的值
        /// </summary>
        /// <param name="c">傳遞類別</param>
        private static void ClassTaker(TheClass c)
        {
            c.x = 5;
        }

        private static void Main(string[] args)
        {
            #region Struct

            TheStruct st = new TheStruct();

            st.x = 1;

            StructTaker(st);

            Console.WriteLine(st.x); // output : 1

            #endregion Struct

            #region Class

            TheClass cs = new TheClass();

            cs.x = 1;

            ClassTaker(cs);

            Console.WriteLine(cs.x); // output : 5

            #endregion Class
        }
    }
}