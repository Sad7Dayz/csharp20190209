using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest
{
    [AdditionalInfoAttribute("홍길동", "2018/10/1", Downdload ="http://ojc.asia")] //po파라메터 , 명령 파라메터
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            foreach(Attribute attr in type.GetCustomAttributes(true))
            {
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute; //attr additional 형변환
                if (info != null)
                    Console.WriteLine("Name={0}, Update={1}," + "DownLoad={2}", info.Name, info.Update, info.Downdload);
            }
        }
    }
}
