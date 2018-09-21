using System;
using System.IO;

namespace Курс_по_алгоритмам_ИТМО
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            string[] str = sr.ReadLine().Split(' ');
            long a = long.Parse(str[0]);
            long b = long.Parse(str[1]);
            long result = a + b * b;
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.WriteLine(result.ToString());
            sw.Dispose();
            sr.Dispose();
        }
    }
}
