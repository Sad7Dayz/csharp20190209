﻿using System;
using System.Threading;

namespace ConsoleApp39
{
    public class ThreadTest3
    {
        public string lockString = "hello";
        private object obj = new object();
        public void Print(string rank)
        {
            lock (obj)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write(",s");
                    }
                    Console.WriteLine("{0}{1}", rank, lockString);
                }
            }
        }
        public void FirstWork() { Print("F"); }
        public void SecondWork() { Print("S"); }
    }

    class TestMain
    {
        [MTAThread]
        public static void Main()
        {
            ThreadTest3 t = new ThreadTest3();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Start();
            second.Start();
        }
    }
}
