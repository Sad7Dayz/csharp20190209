using System;
using System.Collections;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        
        //Hashtable onj = new Hashtable(); //해쉬테이블
        Dictionary<String, String> onj = new Dictionary<string, string>(); //제널닉형태

        onj.Add("김길동", "서울");
        onj.Add("홍길동", "광주");
        onj.Add("박길동", "부산");

        try
        {
            onj.Add("김길동", "서울");
        }

        catch
        {
            Console.WriteLine("키값 중복....");
        }

        Console.WriteLine("For Key = \"name\", value = {0}.", onj["홍길동"]);

        onj["박길동"] = "제주";

        Console.WriteLine("For Key = \"name\", value = {0}.", onj["박길동"]);

        if(!onj.ContainsKey("최길동"))
        {
            onj.Add("최길동", "하와이");
            Console.WriteLine("value added for key = \"who\":{0}", onj["최길동"]);
        }
        Console.WriteLine();

        //foreach (DictionaryEntry d in onj) //해쉬테이블
        foreach (KeyValuePair<string,string> d in onj) //제널닉형태
        {
            Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
        }

        SortedList s = new SortedList(onj);

        foreach(DictionaryEntry d in s)
        {
            Console.WriteLine("key = {0}, value={1}", d.Key, d.Value);            
        }
    }
}