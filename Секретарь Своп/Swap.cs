using System;
using System.IO;

namespace Секретарь_Своп
{
    class Swap
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            int size = int.Parse(sr.ReadLine());
            long[] arr = new long[size];
            string[] str = sr.ReadLine().Split(' ');
            for (int i = 0; i < size; i++)
                arr[i] = long.Parse(str[i]);
            long[] result = new long[size];
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                //поиск минимального числа
                long min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                long temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
                if (min != i)
                {
                    if (min < i)
                        sw.WriteLine("Swap elements at indices {0} and {1}.", min + 1, i + 1);
                    else
                        sw.WriteLine("Swap elements at indices {0} and {1}.", i + 1, min + 1);
                }                   
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int j = i;
            //    while (j > 0 && result[j - 1] > arr[i])
            //    {
            //        result[j] = result[j - 1];
            //        j--;
            //    }
            //    result[j] = arr[i];
            //    if (j != i)
            //        sw.WriteLine("Swap elements at indices {0} and {1}.", j + 1, i + 1);
            //}
            sw.WriteLine("No more swaps needed.");
            for (int i = 0; i < arr.Length; i++)
                sw.Write(arr[i] + " ");
            sw.Dispose();
            sr.Dispose();
        }
    }
}
