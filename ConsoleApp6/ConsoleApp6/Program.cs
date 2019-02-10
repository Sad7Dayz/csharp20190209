using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Dog
    {
        public string Name { get; set; }
        public abstract void jitda(); //추상 메소드
    }

    public class Pudle : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(Name + "푸들푸들~");
        }

        public void Work()
        {
            Console.WriteLine(Name + "가 일한다.");
        }
    }

    public class jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(Name + "진도진도~");
        }

        public void Run()
        {
            Console.WriteLine(Name + "가 달린다.");
        }
    }

    class DogManager
    {
        static void Main()
        {
            Dog p = new Pudle();
            p.Name = "푸들이";
            p.jitda();
            ((Pudle)p).Work();


            Dog j = new jindo();
            j.Name = "진도이";
            j.jitda();
            ((jindo)j).Run();
        }

    }

}
