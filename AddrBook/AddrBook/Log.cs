using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook
{
    class Log
    {
        public static void WriteLine(string name, string e)
        {
            string filename = @"C:\dotnet\" + name + "_log";
            string logtime = DateTime.Now.ToString();

            FileStream aFile = new FileStream(filename, FileMode.Append, FileAccess.Write);

            StreamWriter aWriter = new StreamWriter(aFile, System.Text.Encoding.Default);

            aWriter.WriteLine("[" + logtime + "]");
            aWriter.WriteLine(e);
            aWriter.Flush();
            aWriter.Close();
        }
    }
}
