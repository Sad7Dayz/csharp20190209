﻿using System;

class Program
{
    static void Main(string[] args)
    {
        //Method1이 false라도 Method2 실행
        Console.WriteLine("정상적인AND:");
        if (Method1() & Method2())
            Console.WriteLine("Both methods returned true");
        else
            Console.WriteLine("둘중 하나의 메소드는 false");
        //Method1이 false면 Method2는 실행 되지 않는다.
        Console.WriteLine("\n Short-circuit AND: ");

        if (Method1() && Method2())
            Console.WriteLine("Both methods returned true");
        else
            Console.WriteLine("둘중 하나의 메소는 false");

        Console.WriteLine("0x{0:x}", 0xf8 & 0x3f); //0x38
    }

    static bool Method1()
    {
        Console.WriteLine("메소드1...");
        return false;
    }
    
    static bool Method2()
    {
        Console.WriteLine("메소드2...");
        return true;
    }
}

