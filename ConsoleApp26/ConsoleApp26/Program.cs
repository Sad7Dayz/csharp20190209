﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp26
//{
//    delegate bool OjcDeligate(object obj1, object obj2);

//    class OjcSorter
//    {
//        public static void BubbleSort(object[] obj, OjcDeligate deli)
//        {
//            object tmp;

//            for(int i = 0; i<obj.Length; i++)
//            {
//                for(int j = 0; j < i; j++)
//                {
//                    if(deli(obj[j], obj[i]))
//                    {
//                        tmp = obj[i];
//                        obj[i] = obj[j];
//                        obj[j] = tmp;
//                    }
//                }
//            }
//        }

//        class Dog
//        {
//            string name;
//            public Dog(string name)
//            {
//                this.name = name;
//            }

//            public static bool MySort(object d1, object d2)
//            {
//                return ((((Dog)d1).name.CompareTo(((Dog)d2).name) > 0) ? true : false);
//            }

//            public override string ToString()
//            {
//                return "Dog:" + name;
//            }
//        }

//        class Emp
//        {
//            string name;
//            int sal;
//            public Emp(string name, int sal)
//            {
//                this.name = name;
//                this.sal = sal;
//            }
//            public static bool MySort(object e1, object e2)
//            {
//                return ((((Emp)e1).sal > ((Emp)e2).sal) ? true : false);
//            }
//            public override string ToString()
//            {
//                return "Emp : " + name + "," + sal;
//            }
//        }

//        class Program
//        { 
//            static void Main(string[] args)
//            {
//                Dog[] d = new Dog[4];
//                d[0] = new Dog("멍멍이");
//                d[1] = new Dog("푸들이");
//                d[2] = new Dog("진도이");
//                d[3] = new Dog("삽살이");

//                OjcDeligate deli = new OjcDeligate(Dog.MySort);
//                OjcSorter.BubbleSort(d, deli);

//                Console.WriteLine("<<<<<<<<<<<<<Dog정렬된 후 >>>>>>>");

//                foreach(Dog dog in d)
//                {
//                    Console.WriteLine(dog);
//                }

//                Console.ReadLine();

//                Emp[] e = new Emp[4];
//                e[0] = new Emp("홍길이", 900);
//                e[1] = new Emp("남길이", 800);
//                e[2] = new Emp("오라클자바커뮤니티", 5000);
//                e[3] = new Emp("김길동", 100);

//                deli = new OjcDeligate(Emp.MySort);

//                OjcSorter.BubbleSort(e, deli);

//                Console.WriteLine("<<< emp 급여순 정렬된 후 >>>");
//                foreach(Emp emp in e)
//                {
//                    Console.WriteLine(emp);
//                }

//            }
//        }
//    }
//}
//------------------------------------


using System;
namespace ConsoleApplication11
{
    class Program
    {
        delegate int Calc(int i, int j);
        static void Main(string[] args)
        {
        Calc c = new Calc(MySum); //이 델리게이트는 이름있는 외부 메소드를 참조
            Console.WriteLine("1+2={0}", c(1, 2));
            Calc c1 = delegate (int i, int j) //델리게이트를 이용한 익명 메소드
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}", c1(3, 4));
        }
        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}
