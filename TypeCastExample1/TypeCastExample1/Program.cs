using System;
using System.Runtime.InteropServices;

class TypeCastEmample1
{
    static void Main(string[] args)
    {
        Console.WriteLine(default(int));

        int iSize = sizeof(int); //int형의 사이즈
        Console.WriteLine("int형 바이트길이 : {0}", iSize);

        Type myType1 = typeof(int); // system.int32원형
        Console.WriteLine("type(int) : {0}", myType1);

        int i = 10;
        Type myType2 = i.GetType(); // i의 타입원형
        Console.WriteLine("i.GetType() : {0}", myType2);

        int j = 99;
        Console.WriteLine("size of j : {0}", Marshal.SizeOf(j)); //Marshal은 System.runtime.ineropServives에서 변수의 길이 구함.
    }
}
