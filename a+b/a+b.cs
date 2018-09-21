using System;
using System.IO;

namespace a_b
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            string[] str = sr.ReadLine().Split(' ');
            long a = long.Parse(str[0]);
            long b = long.Parse(str[1]);
            long result = a + b;
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.WriteLine(result.ToString());
            sw.Dispose();
            sr.Dispose();
        }
    }
}
