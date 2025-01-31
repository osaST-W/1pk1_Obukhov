using System.Runtime.CompilerServices;

namespace Task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
            модулю были разными.Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
            двух равных по модулю.В полученном массиве найти наибольшее по модулю число.*/

            int[] x = new int[5];
            Random rnd = new Random();
            for ( int i = 0; i < x.Length;i++)
            {
                int c = rnd.Next(0, 10);
                bool isExist = false;
                for(int j = 0; j< i; j++)
                {
                    if (Math.Abs(c) == Math.Abs(x[j]))
                        isExist = true;
                }
                if (isExist)
                {
                    i++;
                    continue;
                }
                else
                    x[i] = c;
                Console.Write(x[i]+" ");
            }
           
            
            
        }
    }
}
