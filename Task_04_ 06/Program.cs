namespace Task_04__06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Используем HashSet для хранения уникальных чисел
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Random rnd = new Random();
            int number;

            while (uniqueNumbers.Count < 20)
            {
                // Генерируем случайное число в диапазоне от -30 до 30
                number = rnd.Next(-30, 31);

                // Проверяем, чтобы оно не было равным самому себе 
                // Проверяем, чтобы в HashSet не было этого числа или его модульного значения
                if (!uniqueNumbers.Contains(number) && !uniqueNumbers.Contains(-number))
                {
                    // Добавляем число в HashSet
                    uniqueNumbers.Add(number);
                }
            }

            // Преобразуем HashSet обратно в массив
            int[] resultArray = uniqueNumbers.ToArray();

            // Выводим результат
            foreach (var num in resultArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
