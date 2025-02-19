namespace Task_11_08
{
    internal class Program
    {/*Использование params и out: Напишите метод, который принимает переменное количество
      чисел и возвращает их сумму и максимальное значение через выходные параметры (out).*/
        static void Main()
        {
            int sum;
            int max;

            // Вызов метода с примером чисел
            CalculateSumAndMax(3, 5, 7, 2, 8, 1, out sum, out max);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Максимальное значение: {max}");
        }

        static void CalculateSumAndMax(int[] numbers, out int sum, out int max)
        {
            sum = 0;
            max = int.MinValue;

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
        }

        // Перегруженный метод с params
        static void CalculateSumAndMax(int firstNumber, params int[] otherNumbers)
        {
            int sum;
            int max;

            CalculateSumAndMax(new int[] { firstNumber }.Concat(otherNumbers).ToArray(), out sum, out max);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Максимальное значение: {max}");
        }
    }

}

