namespace Task_03__09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
            отбрасывается.Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
            менее y рублей.
            */



            //Входные данные
            Console.WriteLine("Введите сумму вклада");
            decimal x = decimal.Parse(Console.ReadLine()); //сумма вклад
            Console.WriteLine("Введите процентную ставку");
            decimal p = decimal.Parse(Console.ReadLine()); //проценты
            Console.WriteLine("Введите сумму, которую должна привышать сумма вклада");
            decimal y = decimal.Parse(Console.ReadLine()); //число, которое должна привышать сумма вклада

            int year = 0;
            while (x < y)
            {
                x += Math.Floor(x * p / 100);
                year++;
            }
            Console.WriteLine($"Через {year} лет сумма вклада привысит заданную сумму");
        }
    }
}
