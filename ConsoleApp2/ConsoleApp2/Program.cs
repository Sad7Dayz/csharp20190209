using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(j:10,i:20)); //sum의 순서를 명령할수 있음. 명령안할시에 순차적으로 들어감.
            Console.WriteLine(Sum(j: 10));
            Console.WriteLine(Sum(20));
            Console.WriteLine(Sum());
        }
        //static int Sum(int i, int j) //첫번째 console부분
        static int Sum(int i=0, int j=0)
        {
            return i + j;
        }
    }
}
