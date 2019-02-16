using System;

namespace ConsoleApp27
{
    class EventPublisher
    {
        //public delegate void MyEventHandler();
        public event EventHandler MyEvent;
        public void Do()
        {
            MyEvent(null, null);
        }
    }

    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();

            //p.MyEvent += new EventHandler(doAction);

            p.MyEvent += doAction;

            p.MyEvent += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("");
            };

            p.MyEvent += (sender, e) =>
            {
                Console.WriteLine("myEnvent라는 이벤트 발생");
            };
        }

        private static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent라는 이벤트 발생...");
        }
    }
}
