using System;
class Emp
{

}
class Programmer:Emp
{

}
class EmpTest
{ 
    static void Main(string[] args)
    {
        Emp e = new Emp();
        Programmer p = new Programmer();
        Emp e1 = p as Emp;
        Emp e2 = (Emp)p;

            //if(p is Emp) //is는 객체 타입을 비교 연산자
            //{
            //    Console.WriteLine("Progrmmer is Emp");
            //}
            //else
            //{
            //    Console.WriteLine("programmer is not emp");
            //}
    }
}
