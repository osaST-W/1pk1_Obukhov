using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
       
            
            {
            { 
            /*Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
            расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
            этом*/

            Console.WriteLine("Введите вашу дату рождения( год, месяц, день)");
            int g = Int32.Parse(Console.ReadLine()); //год
            
            int m = Int32.Parse(Console.ReadLine()); //месяц
            
            int d = Int32.Parse(Console.ReadLine()); //день
                Console.Clear();
            
            do //внешний цикл
            {
                if (g <= 2025) 
                {
                    Console.WriteLine("Год: "+ g);
                }
                else if ( g> 2025)
                {
                    Console.WriteLine("Введен некореектный возраст");
                }
                break;
            }
            while (true);

            do //внеш цикл
            {
                if (m <= 12) 
                {
                    Console.WriteLine("Месяц: " + m);
                }
                else if (m > 12) 
                {
                    Console.WriteLine("Введен некореектный возраст");
                }
                break;
            }
            while (true);

            do //внешний цикл
            {
                if (d <= 31) // внутр цикл 
                {
                    Console.WriteLine("День: " + d);
                }
                else if (d > 31) 
                {
                    Console.WriteLine("Введен некореектный возраст");
                }
                break;
            }
            while (true);

                // Получаем текущую дату
                int currentG = 2025; // Введите текущий год
                int currentM = 1; // Введите текущий месяц
                int currentD = 28; // Введите текущий день

                // Проверка на совершеннолетие
                bool isAdult = false;

                if (currentG > g + 18) // внеш цикл
                {
                    isAdult = true;
                }
                else if (currentG == g + 18)
                {
                    if (currentM > m) // внутр цикл 1
                    {
                        isAdult = true;
                    }
                    else if (currentM == m)
                    {
                        if (currentD >= d) // внутр цикл 2
                        {
                            isAdult = true;
                        }
                    }
                }

                // Вывод результата
                if (isAdult)
                {
                    Console.WriteLine("Вы совершеннолетний.");
                }
                else
                {
                    Console.WriteLine("Вы несовершеннолетний.");
                }




            }
        }
    }
}

