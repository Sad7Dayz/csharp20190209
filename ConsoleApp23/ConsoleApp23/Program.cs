using System;

class Delegate1
{
    private delegate int OnjSum(int i, int j);

    public static void Main(string[] args)
    {
        OnjSum myMethod = new OnjSum(Delegate1.Sum);

        Console.WriteLine("두수의 합 : {0}", myMethod(10, 30));
    }

    static int Sum(int i, int j)
    {
        return i + j;
    }
}

