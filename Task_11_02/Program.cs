using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Task_11_02
{
    internal class Program
    {  //Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
       // меняет их местами.Проверьте, изменились ли значения переменных вне метода
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main (string[] args)
        {
            int number1 = 2;
            int number2 = 3;

            Console.WriteLine($"До обмена: number1 = {number1}, number2 = {number2}");

            // Вызов метода Swap с передачей переменных по ссылке
            Swap(ref number1, ref number2);

            Console.WriteLine($"После обмена: number1 = {number1}, number2 = {number2}");
        }
    }
}
