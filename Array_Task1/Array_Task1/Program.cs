using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random _rnd = new Random();

            int N = 20;
            int[] arrayN = InitializeArray(N);
            Console.WriteLine("Исходный массив:");
            PrintArray(arrayN, arrayN.Length, 0);
            Console.WriteLine();

            int M = _rnd.Next(1, 11);
            int[] arrayM = InitializeArray(M);
            Console.WriteLine("Добавляемые элементы:");
            PrintArray(arrayM, arrayM.Length, 0);
            Console.WriteLine();

            int K = _rnd.Next(0, arrayN.Length);
            Console.WriteLine($"После {K} элемента будут добавляться новые числа.");
            PrintArray(arrayN,K, 0);
            PrintArray(arrayM, arrayM.Length, 0);
            PrintArray(arrayN, arrayN.Length, K);
            Console.ReadLine();
        }
        static int[] InitializeArray(int n)
        {
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1,101);
            }

            return array;
        }
        static void PrintArray(int[] array, int l, int s)
        {
            for (int i = s; i < l; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
