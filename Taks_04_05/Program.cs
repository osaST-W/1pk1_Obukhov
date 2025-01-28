using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Taks_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] C = new int[30];
            Random rnd = new Random();
            for (int i = 0; i < C.Length; i++) // заполним массив случайными числами от 0 до 300
            {
                C[i] = rnd.Next(0, 301);
            }
            //Вычислим общее кол-во осадков в каждой декаде ( 3 декады по 10 дней)
            int[] D = new int[3];
            for (int x = 0; x < D.Length; x++)
            {
                D[x / 10] += C[x];
            }
            // определим динь с самыми высоким показаетлем выпавших осадков ( нужно учитвыать, что отсчет начнется с 1)
            int MaxC = C [0];
            int MaxD = 1;
            for ( int M = 1; M < C.Length; M++)
            {
                if (C[M] > MaxC)
                {
                    MaxC = C[M];
                    MaxD = M + 1;
                }
            

            }
            // Находим дни без осадков
            Console.WriteLine("Дни без осадков:");
            for (int i = 0; i < C.Length; i++)
            {
                if (C[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
            }
            // Выводим результаты
            Console.WriteLine("\nОбщее количество осадков за каждую декаду:");
            for (int i = 0; i < D.Length; i++)
            {
                Console.WriteLine($"Декада {i + 1}: {D[i]} мм");
            }
            Console.WriteLine($"\nДень с самыми сильными осадками: {MaxD} (осадки: {MaxC} мм)");




        }
    }
}
