using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInstrmentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Run1();
            Run2();
            Run3(); 
        }

        private static Object thisLock = new Object();

        private static void Run1() 
        {
            Int64 balance = 0;
            var data = Enumerable.Range(0, 800)
            .AsParallel();

            data.ForAll(x =>
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        lock (thisLock)
                        {
                            balance += j;
                        }
                    }
                }
            });

            Console.WriteLine("Run 1 Finish");

        }

        private static void Run2()
        {
            Int64 balance = 0;
            var data = Enumerable.Range(0, 2500)
            .AsParallel();

            data.ForAll(x =>
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        lock (thisLock)
                        {
                            balance += j;
                        }
                    }
                }
            });

            Console.WriteLine("Run 2 Finish");

        }

        private static void Run3()
        {
            Int64 balance = 0;
            var data = Enumerable.Range(0, 100)
            .AsParallel();

            data.ForAll(x =>
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        lock (thisLock)
                        {
                            balance += j;
                        }
                    }
                }
            });

            Console.WriteLine("Run 3 Finish");

        }
        
        
        private static Int64 ComsumingHighPerformance(int number) 
        {
            Int64 balance = 0;
            var data = Enumerable.Range(0, number)
            .AsParallel();

            data.ForAll(x =>
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        lock (thisLock)
                        {
                            balance += j;
                        }                        
                    }
                }
            });

            return balance;
        }

        private static void CommonMethod() 
        {
            Console.WriteLine("Nothing");
        }
    }
}
