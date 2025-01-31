namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов
        отдельно для 1-ой и 2-ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
        использовать нельзя.
        Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
        Результат: [4,0,-10,2,5,-7,9,2,7,-6]*/

            int[] array = new int[10];
            Random rnd = new Random();

            // Заполним массив случайными числами в интервале [-10..10]
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 11); // Генерация случайного числа от -10 до 10
            }

            // Вывод исходного массива
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            // Реверс первой половины
            int mid = array.Length / 2;
            for (int i = 0; i < mid / 2; i++)
            {
                // Меняем местами элементы
                int temp = array[i];
                array[i] = array[mid - 1 - i];
                array[mid - 1 - i] = temp;
            }

            // Реверс второй половины
            for (int i = mid; i < mid + (array.Length - mid) / 2; i++)
            {
                // Меняем местами элементы
                int temp = array[i];
                array[i] = array[array.Length - 1 - (i - mid)];
                array[array.Length - 1 - (i - mid)] = temp;
            }

            // Вывод итогового массива
            Console.WriteLine("Результат: " + string.Join(", ", array));
        }

    }
}

