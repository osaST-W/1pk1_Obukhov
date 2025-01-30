namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, которая выводит таблицу скорости(через каждые 0, 5с) свободно падающего тела v = g t ,
            //где 2 g = 9,8 м / с2 – ускорение свободного падения.

            double g1 = 9.8;
            double g2 = 0;
            double t = 0.5;
            Console.WriteLine("--------------------------------------------------");
            for (double i = g1; i >= g2; i -= t) // подсчет занчений
                
            {
                double v = i * t;
                Console.WriteLine($" \t g {i} | \t v {v}");
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
