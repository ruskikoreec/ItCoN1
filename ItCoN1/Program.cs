using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCoN1
{
    internal class Program
    {
        static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min_index] > arr[j])
                    {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    int temp = arr[min_index];
                    arr[min_index] = arr[i];
                    arr[i] = temp;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            string s1;
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                s1 = sr.ReadLine();
            }
            Console.WriteLine("Неотсортированный массив: " + s1);
            int[] arr = s1.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Sort(arr);
            var str = string.Join(" ", arr);
            Console.WriteLine("Отсортированный массив: " + str);
            Console.ReadKey();
        }
    }
}

