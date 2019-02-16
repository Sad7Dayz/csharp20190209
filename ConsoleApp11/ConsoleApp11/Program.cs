using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 } };
            int[,] b = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            foreach ( int[] i in a)
            {
                foreach(int j in i)
                {
                    Console.Write(j + "");
                }
            }
            Console.WriteLine("\n --------------\n");

            //이차원 배열 출력
            foreach(int i in b)
            {
                Console.Write(i + "");
            }
        }
    }
}
