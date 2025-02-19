namespace Task_10_06
{
    internal class Program
    {/*Создать Метод ArrayGeneration не возвращающий значения,  
      * принимает целое число n, выводит на консоль 
      * сгенерированный массив размерности n*n.*/
        static void Main(string[] args)
        {

            // Проверка на корректность ввода числа
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                ArrayGeneration(n);
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число.");
            }
        }

        static void ArrayGeneration(int n)
        {
            // Создаем двумерный массив размером n*n
            int[,] array = new int[n, n];

            // Генерируем случайные числа и заполняем массив
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 100); // Генерируем случайные числа от 0 до 99
                }
            }

            // Выводим массив на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(); // Переход на новую строку после вывода строки массива
            }
        }
    }
}
