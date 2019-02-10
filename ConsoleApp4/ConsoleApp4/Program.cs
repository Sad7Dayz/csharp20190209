using System;

namespace PropertyTest
{
    class Emp : Object      //클래스의 제일 위를 object라 한다. 
    {
        public int Empno { get; set; }
        public override string ToString()
        {
            return $"[사원: {Empno}]";
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();  //e는 객체 참조 변수
            e.Empno = 999;//set
            Console.WriteLine(e);
            Console.WriteLine(e.Empno);//get
            Console.WriteLine(e.ToString());
        }
    }
}
