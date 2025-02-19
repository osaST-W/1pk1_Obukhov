namespace Task_11_04
{
    internal class Program
    {/*Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
     их среднее значение. Используйте ключевое слово params*/
       
            static void Main(string[] args)
            {
                // Пример использования метода
                double average1 = CalculateAverage(1, 2, 3, 4, 5);
                Console.WriteLine($"Среднее значение: {average1}");

                double average2 = CalculateAverage(10, 20, 30);
                Console.WriteLine($"Среднее значение: {average2}");
            }

            // Метод для вычисления среднего значения
            static double CalculateAverage(params double[] numbers)
            {
                if (numbers.Length == 0) // Проверка на случай, если массив пустой
                {
                    throw new ArgumentException("Массив чисел не может быть пустым.");
                }

                double sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }

                return sum / numbers.Length; // Возвращаем среднее значение
            }
        }
    }
    

