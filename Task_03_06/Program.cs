using System.Security.Cryptography;

namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥| для - 4≤x≤4, с шагом h = 0,5.
            double x1 = -4;
            double x2 = 4;
            double h = 0.5;
            Console.WriteLine("--------------------------------------------------");
            for ( double i = x1; i <= x2; i += h)
            {
                double y = Math.Abs(i);
                Console.WriteLine($"\t X: {i,10:F1} | \t Y: {y,10:F1}");
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
