namespace Task_11_07
{
    internal class Program
    {/*Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по
      ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
        оригинальный массив вне метода.*/
            static void Main()
            {
                int[] array = { 1, 2, 3, 4, 5 };
                Console.WriteLine("Оригинальный массив: " + string.Join(", ", array));

                IncreaseElements(array);

                Console.WriteLine("Измененный массив: " + string.Join(", ", array));
            }

            static void IncreaseElements(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]++;
                }
            }
    }
}

