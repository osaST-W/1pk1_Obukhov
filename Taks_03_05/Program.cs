using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
               Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
               время работы программы*/





            // Ввод диапазона температур и шага
            Console.Write("Введите начальную температуру в градусах Цельсия: ");
            double startCelsius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечную температуру в градусах Цельсия: ");
            double endCelsius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите шаг изменения температуры в градусах Цельсия: ");
            double step = Convert.ToDouble(Console.ReadLine());

            // Вывод заголовка таблицы
            Console.WriteLine("\nТемпература в Цельсиях\tТемпература в Фаренгейтах");
            Console.WriteLine("--------------------------------------------------");
            // Вычисление и вывод температуры в Фаренгейтах
            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius,20:F2}\t\t{fahrenheit,20:F2}");
            }

            Console.WriteLine("--------------------------------------------------");




        }
    }
}
