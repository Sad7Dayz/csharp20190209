﻿using System;

namespace Day1
{
    enum Day1 //int형
    {
        Monday, Thesday, Wendnesday, Thursday, Friday, Saturday, Sunday
    }

    enum Day2 : byte //byte형 상속
    {
        Monday = 11, Thesday, Wendnesday, Thursday, Friday, Saturday, Sunday = Monday + 100
    }
    public class EnumTest
    {
        static void Main(string[] args)
        {
            Day1 whatDay = Day1.Sunday;
            Console.WriteLine("{0}", whatDay);      //Sunday
            Console.WriteLine("{0}", (int)whatDay); //6

            whatDay = (Day1)6;
            Console.WriteLine("{0}", whatDay);      //Sunday

            Day2 whatDay2 = Day2.Monday;
            Console.WriteLine("{0}", whatDay2);      //Monday
            Console.WriteLine("{0}", (byte)whatDay2);//11

            whatDay2 = (Day2)111;
            Console.WriteLine("{0}", whatDay2);     //Sunday

        }
    }
}
