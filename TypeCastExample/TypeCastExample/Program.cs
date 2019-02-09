using System;

class TypeCastExample1
{
    public static void Main()
    {
        short a = 10;
        int b = a;          //short형은 int형에 묵시적으로 변환되어 대입
        int c = 50000;      //이진수"0000 0000 0000 0000 1100 0011 0101 0000" 표현
                            //short형으로 변환하면 부호비트가 0에서 1로, 음수가 된다.
        try
        {
            short d = checked((short)c); //명시적으로 형변환하지 않으면 오류, 오버플로우 검사하여 예외 발생.
            Console.WriteLine("Short: {0}", d);
        }
        catch (Exception e) //모든에러의 예외 받기
        {
            Console.WriteLine(e.Message);   //에러 메세지
            Console.WriteLine(e.StackTrace);//에러 발생된 줄
        }
    }
}
