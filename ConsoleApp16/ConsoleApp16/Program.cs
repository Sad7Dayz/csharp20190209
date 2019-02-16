using System;
using System.Collections;

public class MyStack
{
    public static void Main()
    {
        Stack myStack = new Stack();
        myStack.Push("ojc");
        myStack.Push("aisa");
        myStack.Push("thank you");

        Console.WriteLine("mystack의 건수:{0}", myStack.Count);

        Console.WriteLine(myStack.Pop());

        Console.WriteLine(myStack.Peek());

        PrintValues(myStack);
    }

    private static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0}", obj);
        Console.WriteLine();
    }
}
