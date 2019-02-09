using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = null;
            object b = "abc";

            //Null-Coalesce Operator, a,b중 NULL이 아닌것을 C에 대입
            object c = a ?? b;
            Console.WriteLine(c);

            //---------------
            object d;

            if(a !=null)
            {
                d = a;
            }
            else
            {
                d = b;
            }

            Console.WriteLine(d);

            //-----------------

            object e;
            e = (a != null) ? a : d; //3항 연산자, ternary operator
            Console.WriteLine(e);
        }
    }
}
