using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Swap(out int a, out int b)
        //static void Swap(int a, int b)
        {
            //int tmp = a;
            //a = b;
            //b = tmp;
            a = 10;
            b = 20;

        }

        static void Main(string[] args)
        {
            int a;
            int b;

            //Console.WriteLine("a={0}, b={1}", a, b);
            Swap(out a, out b);
            //Swap( a, b);
            Console.WriteLine("a={0}, b={1}", a, b);
        }
    }
}
