using System;

class CreaditCard
{
    public string name;
}

class Customer
{
    public int age;
    public CreaditCard card;
    public object ShallowCopy()
    {
        return this.MemberwiseClone();
    }
}

class ArrayTest
{ 
    static void Main()
    {
        Customer c1 = new Customer();
        c1.age = 20;
        c1.card = new CreaditCard();
        c1.card.name = "비씨카드";
        Customer c2 = (Customer)c1.ShallowCopy();
        c2.card.name = "BC카드";

        Console.WriteLine("c1.card.name = " + c1.card.name);
        Console.WriteLine("c2.card.name = " + c2.card.name);
    }
}
