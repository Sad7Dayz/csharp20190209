//using System;

//class OnjMath
//{
//    internal static double MultipleByTwo(double value)
//    {
//        return value * 2;
//    }

//    internal static double Square(double value)
//    {
//        return value * value;
//    }
//}

//delegate double OnjDouble(double x);

//class DelegateTest2
//{
//    static void Main(string[] args)
//    {
//        OnjDouble[] op =
//        {
//            new OnjDouble(OnjMath.MultipleByTwo),
//            new OnjDouble(OnjMath.Square)
//        };

//        for (int i = 0; i < op.Length; i++)
//        {
//            Console.WriteLine("op[{0}] 호출:", i);
//            CallDelegate(op[i], 3.0);
//            Console.WriteLine();
//        }
//}

//    private static void CallDelegate(OnjDouble func, double value)
//    {
//        double ret = func(value);
//        Console.WriteLine("입력된 값은 {0}이고 결과는 {1}이다", value, ret);
//    }
//}


//------------------------------------------------------

//using System;

//class Program
//{
//    public delegate int MyDelegate(int i, int j);
//    public static void Main()
//    {
//        TakesADelegate(new MyDelegate(Add));
//        TakesADelegate(new MyDelegate(Minus));
//        TakesADelegate(new MyDelegate(Gop));
//        TakesADelegate(new MyDelegate(Nanugi));
//    }

//    private static int Nanugi(int i, int j)
//    {
//        return i / j;
//    }

//    private static int Gop(int i, int j)
//    {
//        return i * j;
//    }

//    private static int Minus(int i, int j)
//    {
//        return i - j;
//    }

//    private static int Add(int i, int j)
//    {
//        return i + j;
//    }

//    private static void TakesADelegate(MyDelegate SomeFuction)
//    {
//        Console.WriteLine(SomeFuction(1,2));
//    }
//}

//-----------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace deledatetest
{
    delegate void OnjDelegate(int a, int b);

    class MainApp
    {
        static void Plus(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void Minus(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        void Multiplication(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        void Division(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }

        static void Main()
        {
            //MainApp m = new MainApp();
            //OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
            //    new OnjDelegate(MainApp.Plus),
            //    new OnjDelegate(MainApp.Minus),
            //    new OnjDelegate(m.Multiplication),
            //    new OnjDelegate(m.Division));
            //    CallBack(4, 3);

            MainApp m = new MainApp();
            OnjDelegate CallBack1 = new OnjDelegate(MainApp.Plus);
            OnjDelegate CallBack2 = new OnjDelegate(MainApp.Minus);
            OnjDelegate CallBack3 = new OnjDelegate(m.Multiplication);
            OnjDelegate CallBack4 = new OnjDelegate(m.Division);

            OnjDelegate CallBack = CallBack1 + CallBack2 + CallBack3 + CallBack4;
            CallBack(4, 3);
        }
    }
}

//------------------------------


//using System;
//delegate int SumDeli(int i, int j);
//class DeliTest
//{
//    static void Main()
//    {
//        //델리게이트 생략가능
//        //S1(Sum1), S2(Sum2)
//        SumDeli s1 = DeliTest.Sum1;
//        SumDeli s2 = new SumDeli(DeliTest.Sum2);
//        S(s1); S(s2);
//    }
//    //아래 메소드는 실제 할일(콜백)이 컴파일 타임에 결정되는 것이 아니라 런타임중에
//    //인자로 넘어오는 델리게이트를 통해 결정된다. 이런 콜백의 구현은 델리게이트로
//    static void S(SumDeli s)
//    {
//        Console.WriteLine(s(1, 2));
//    }
//    static int Sum1(int i, int j)
//    {
//        return i + j;
//    }
//    static int Sum2(int i, int j)
//    {
//        return i + j + 100;
//    }
//}
