using System;
using System.Collections.Generic;

namespace EventTest
{
    delegate void MyDelegate(int i);

    class EventPublisher
    {
        //public delegate void MyEventHandler();
        public event MyDelegate CMyEvent;
        public void MyEvent(int Num)
        {
            if (Num % 2 == 0)
                MyEvent(Num);
        }
    }

    class Subscriber
    {  
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.CMyEvent += new MyDelegate(take);

            int[] iArr = Array.ConvertAll(
                (Console.ReadLine()).Split(','),
                i => int.Parse(i));

            foreach(int i in iArr)
            {
                p.MyEvent(i);
            }
        }

        private static void take(int num)
        {
            Console.WriteLine("{0}: 짝~", num);
        }
    }
}