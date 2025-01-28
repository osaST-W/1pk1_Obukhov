﻿namespace Task_03__07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу, которая выводит таблицу скорости(через каждые 0, 5с) свободно падающего тела v = g t ,
               где 2 g = 9,8 м / с2 – ускорение свободного падения.*/

            const double g = 9.8; // Ускорение свободного падения в м/с²
            double timeInterval = 0.5; // Интервал времени в секундах
            double maxTime = 10.0; // Максимальное время в секундах

            Console.WriteLine("Время (с) | Скорость (м/с)");
            Console.WriteLine("-------------------------");

            for (double t = 0; t <= maxTime; t += timeInterval)
            {
                double velocity = g * t;
                Console.WriteLine($"{t,10:f1} | {velocity,14:f2}");
            }
        }
    }
}
