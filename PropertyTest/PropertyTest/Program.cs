using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    class Emp : Object      //클래스의 제일 위를 object라 한다. 
    {
        //internal int empno; //private는 emp클래스안에서만 돼고 internal은 자식클래스까지 된다.
        //변수를 직접적으로 연결하면 값이 변경돼면 문제생김.

        private int empno; //인스턴스 변수
        public void SetEmpno(int empno) //Setter 값을 받기 위한, int empno 지역변수
        {
            this.empno = empno; //this는 앞으로 일어날 자기 자신을 객체,  this.empno = object, empno = int empno이다.
        }

        public int GetEmpno() // Getter 값을 얻기 위한
        {
            return this.empno;
        }

        public override string ToString() //재정의
        {
            return $"[사원:{empno}]";
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();  //e는 객체 참조 변수
            e.SetEmpno(999);
            Console.WriteLine(e);
            Console.WriteLine(e.GetEmpno());
            Console.WriteLine(e.ToString());
        }
    }
}
