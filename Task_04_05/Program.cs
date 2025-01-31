using System;

namespace Task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*В массиве хранятся сведения о количестве осадков за месяц(30 дней).Необходимо определить общее
            количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
            отдельно вывести дни без осадков.Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
            осадков, до 300 мм выпавших осадков.*/

            const int day = 30; //кол-во дней


            Random rnd = new Random(); // массив для хранения осадков
            int[] o = new int[day];


            // Заполнение массива случайными значениями от 0 до 300
            for (int i = 0; i < day; i++)
            {
                o[i] = rnd.Next(0, 301);
            }
            // Вывод значений осадков за каждый день
            Console.WriteLine("Осадки за каждый день:");
            for (int i = 0; i < day; i++)
            {
                Console.WriteLine($"День {i + 1}: {o[i]} мм");
            }

            // Подсчет общего количества осадков за каждую декаду
            for (int decade = 0; decade < 3; decade++)
            {
                int s = decade * 10; // декада 10 дней
                int x = s + 10; // повотор подсчета
                int totalO = 0; // значение осадков

                for (int i = s; i < s; i++)
                {
                    totalO += o[i];
                }

                Console.WriteLine($"Общее количество осадков за декаду {decade + 1}: {totalO} мм");
            }

            // Нахождение дня с самыми сильными осадками
            int maxO = 0;
            int maxDay = 0;

            for (int i = 0; i < day; i++)
            {
                if (o[i] > maxO)
                {
                    maxO = o[i];
                    maxDay = i + 1; // день начинается с 1
                }
            }

            Console.WriteLine($"День с самыми сильными осадками: день {maxDay} ({maxO} мм)");

            // Вывод дней без осадков
            Console.WriteLine("Дни без осадков:");
            for (int i = 0; i < day; i++)
            {
                if (o[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
            }
        }
    }
}
