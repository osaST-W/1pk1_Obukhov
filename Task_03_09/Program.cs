namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
            отбрасывается.Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
            менее y рублей.
            Примеры
            входные данные
            100
            10
            200
            выходные данные
            8*/

            //Входные данные
            Console.WriteLine("Введите началную сумму");
            double x = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Введите процентную ставку");
            double p = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму, которую должна привышать начальная сумма");
            double y = Int32.Parse(Console.ReadLine()); 

            int year = 0;

            for ( double i = x; i <= y; x *= p) //округление значений и подсчет лет
            {
                i = Math.Abs(i);
                i += x;
                year++;

            }
            Console.WriteLine($"Через {year} (год/-а) лет начальная сумма привысит заданную");
            


        }
    }
}
