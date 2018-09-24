using System;
using System.IO;

namespace Знакомство_с_жителями_Сортлэнда
{
    class SortLand
    {
        private static int[] Sorting (double[] arr, int[] indexes)
        {
            double temp;
            int tmp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        tmp = indexes[i];
                        indexes[i] = indexes[j];
                        indexes[j] = tmp;
                    }
                }
            }
            return indexes;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            int size = int.Parse(sr.ReadLine());
            double[] arr = new double[size];
            string mas = sr.ReadLine();
            mas = mas.Replace('.', ',');
            string[] str = mas.Split(' ');
            for (int i = 0; i < size; i++)
                arr[i] = double.Parse(str[i]);
            int[] indexes = new int[size];
            for (int i = 0; i < size; i++)
                indexes[i] = i + 1;
            int[] newindexes = new int[size];
            newindexes = Sorting(arr, indexes);
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.Write(newindexes[0] + " " + newindexes[arr.Length / 2] + " " + newindexes[arr.Length - 1]);
            sw.Dispose();
            sr.Dispose();
        }
    }
}
