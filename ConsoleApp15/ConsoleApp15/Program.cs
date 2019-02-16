using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SampleArrayList
{
    public static void Main()
    {
        ArrayList onj = new ArrayList();

        onj.Add("onj");
        onj.Add("oraclejava");
        onj.Add("community");

        Console.WriteLine("onj list");
        Console.WriteLine("count: {0}", onj.Count);
        Console.WriteLine("capacity:{0}", onj.Capacity);

        Console.WriteLine("onj values");
        PrintValues(onj);

        ArrayList onj2 = (ArrayList)onj.Clone();
        Console.WriteLine(" onj2 Values:");

        PrintValues(onj2);
    }

    private static void PrintValues(IEnumerable MyList)
    {
        foreach (object obj in MyList)
            Console.Write("{0}", obj);
        Console.WriteLine();
    }
}
