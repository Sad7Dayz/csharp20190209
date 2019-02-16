//using System;
//public class Delegate1
//{
//   // private delegate int OnjSum(int i, int j); //1. 선언
//    public static void Main(string[] args)
//    {
//        //Func<int, int, int> myMethod = new Func<int, int, int>(Sum); //2. 생성, 메소드이름을 인자로
//        // Action<int, int> myMethod = new Action<int, int>(Sum); //2. 생성, 메소드이름을 인자로
//        Action<int, int> myMethod = Sum;
//        myMethod(10, 30);
//    }
//    static void Sum(int i, int j)
//    {
//        System.Console.WriteLine(i + j);
//    }
//}


using System;
delegate int SumDeli(int i, int j);
class DeliTest
{
    static void Main()
    {
        SumDeli s1 = DeliTest.Sum1;
        SumDeli s2 = new SumDeli(DeliTest.Sum2);
        S(s1);
        S(s2);
    }

    private static void S(SumDeli s)
    {
        Console.WriteLine(s(1,2));
    }

    private static int Sum1(int i, int j)
    {
        return i + j;
    }

    private static int Sum2(int i, int j)
    {
        return i + j + 100;
    }

   
}