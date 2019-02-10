using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<10)
            {
                i += 1;
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
