using System;
using System.Collections.Generic;
using System.Linq;
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
            int[] arrayN = new int[N];

            for (int i = 0; i < N; i++)
            {
                arrayN[i] = _rnd.Next(100);
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arrayN.Length; i++)
            {
                Console.Write($" {arrayN[i]} ");
            }
            Console.WriteLine();

            int M = _rnd.Next(1, 11);
            int[] arrayM = new int[M];

            for (int i = 0; i < M; i++)
            {
                arrayM[i] = _rnd.Next(100);
            }
            Console.WriteLine("Добавляемые элементы:");
            for (int i = 0; i < arrayM.Length; i++)
            {
                Console.Write($" {arrayM[i]} ");
            }
            Console.WriteLine();

            int K = _rnd.Next(0, arrayN.Length);    
            Console.WriteLine($"После {K} элемента будут добавляться новые числа.");

            for (int j = 0; j < K; j++)
            {
                Console.Write($" {arrayN[j]} ");
            }

            for (int j = 0; j < M; j++)
            {
                Console.Write($" {arrayM[j]} ");
            }

            for (int j = K; j < N; j++)
            {
                Console.Write($" {arrayN[j]} ");
            }
            Console.ReadLine();
        }
    }
}
