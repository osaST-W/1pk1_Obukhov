using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит в консоли произвольный текст. После каждого ввода консоль очищается.Когда
            //пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            //введенных пользователем.


            Console.WriteLine("Введите любой текст. Для окончания введите слово exit или оставьте строчку пустой");

            int line = 0; // строки

            while (true)
            {
                string temp = Console.ReadLine();
                line++;
                if (temp == "" || temp == "exit") // Условия
                    break;
            }
            Console.WriteLine("Вы ввели " + (line) + " строк" ); //Кол-во строк
        }
    }
}
