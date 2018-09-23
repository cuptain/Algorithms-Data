using System;
using System.IO;

namespace Сортировка_вставками
{
    class InsertionSort
    {
        private static long[] Sorting(long[] arraySort, out int[] indexes)
        {
            indexes = new int[arraySort.Length];
            long[] result = new long[arraySort.Length];
            for (int i = 0; i < arraySort.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > arraySort[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = arraySort[i];
                indexes[i] = j + 1;
            }
            return result;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            int size = int.Parse(sr.ReadLine());
            long[] arr = new long[size];
            string[] str = sr.ReadLine().Split(' ');
            for (int i = 0; i < size; i++)
                arr[i] = long.Parse(str[i]);
            int[] indexes = new int[size];
            long[] result = new long[size];
            result = Sorting(arr, out indexes);
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            for (int i = 0; i < arr.Length; i++)
                sw.Write(indexes[i] + " ");
            sw.WriteLine();
            for (int i = 0; i < arr.Length; i++)
                sw.Write(result[i] + " ");
            sw.Dispose();
            sr.Dispose();
        }
    }
}
