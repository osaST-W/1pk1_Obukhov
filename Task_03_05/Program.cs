namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
             Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
             время работы программы*/

            //Ввод значенй
            Console.WriteLine("Введите начальное занчения градусов Цельсия");
            double C = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение в градусах Цельсия");
            double Di = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            double h = Double.Parse(Console.ReadLine());

            //Проверка корректности введенных данных
          
                if (h < 0 || Di < C)
            {
                Console.WriteLine("Вы ввели некорректные данные");
                return;
                    

            }



            //Выведение таблицы
            Console.WriteLine("--------------------------------------------------");
            for (double c = C; c <= Di; c += h) // c - начало отсчета таблицы
            {
                double f = c * 1.8 + 32;
                Console.WriteLine($"C: {c,10:F1} | \t F: {f,10:F1}");
            }
            Console.WriteLine("--------------------------------------------------");







        }
    }
}
