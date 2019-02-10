using System;
namespace ConsoleApplication8
{
    class MyBaseClass : Object
    {
        public MyBaseClass()
        {
            Console.WriteLine(">>>MyBaseClass()");
        }
        public MyBaseClass(int i)
        {
            Console.WriteLine(">>>MyBaseClass(int i)");
        }
    }

    class MyClass : MyBaseClass
    {
        public MyClass()
        {
             ///////     
            Console.WriteLine(">>>MyClass()");
        }
        public MyClass(int i):base(i)
        {
            Console.WriteLine(">>> MyClass(int i)");
        }

        public MyClass(int i, int j)
        {
            Console.WriteLine(">>>MyClass(int i, int j)");
        }

        public MyClass(int i, int j, int k) : base(i)
        {
            Console.WriteLine(">>>MyClass(int i, int j, int k)");
        }

        public MyClass(int i, int j, int k, int l) : this(i, j)
        {
            Console.WriteLine(">>>MyClass(int i, int j, int k, int l)");
        }
    }
    class Test
    {
        static void Main()
        {
            MyClass m1 = new MyClass();              //MyBaseClass(), MyClass()
            MyClass m2 = new MyClass(1);            //MyBaseClass(), MyClass(int i)
            MyClass m3 = new MyClass(1, 2);         //MyBaseClass(), MyClass(int i, int j)
            MyClass m4 = new MyClass(1, 2, 3);      //MyBaseClass(), MyClass(int i, int j, int k)
            MyClass m5 = new MyClass(1, 2, 3, 4);   //MyBaseClass(), MyClass(int i, int j), MyClass(int i, int j, int k, int l)
        }
    }
}