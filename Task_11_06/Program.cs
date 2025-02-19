namespace Task_11_06
{
    internal class Program
    { /*Передача массива по значению: Напишите метод, который принимает массив целых чисел и
      изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный
      массив вне метода.*/
       
        
            static void Main()
            {
                int[] numbers = { 1, 2, 3, 4, 5 };

                Console.WriteLine("Оригинальный массив:");
                PrintArray(numbers);

                // Вызов метода, который изменяет массив
                IncreaseArrayElements(numbers);

                Console.WriteLine("Измененный массив:");
                PrintArray(numbers);
            }

            static void IncreaseArrayElements(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += 1; // Увеличиваем каждый элемент на 1
                }
            }

            static void PrintArray(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }

