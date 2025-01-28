using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasl_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.*/
            double h = 0.5; //шаг
            double x1 = -4; // начальное значение х
            double x2 = 4; // конченое значение х

            //Ввод заголовка таблицы
            Console.WriteLine("\t значения y" + "\t значения |x|");
            Console.WriteLine("--------------------------------------------------");

            //Вычисление и ввод у
            for (double x = x1; x <= x2; x += h)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x,20:F2}\t\t{y,20:F2}");
            }
            Console.WriteLine("--------------------------------------------------");

        }
    }
}
