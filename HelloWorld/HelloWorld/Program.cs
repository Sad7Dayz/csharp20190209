using System;

namespace HelloWorld
{
    class Program
    {
        int i; //멤버, 필드, 인스턴스변수
        //System.Int32 i; int i와 같음
        static int j; //멤버,변수, 클래스 변수
        static void Main(string[] args)//멤버 메소드
        {
            string name = "홍길동";
            int k = 99;
            Console.WriteLine($"Hello {name}"); //새로나온기법
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello {0}{1}", name, k);
            //system = namespace(분류이름 - 클래스의 소속)
        }
    }
}
