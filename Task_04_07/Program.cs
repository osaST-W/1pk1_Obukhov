using System.Security.Authentication;

namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
             отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
             мальчиков и девочек. При выводе избавиться от отрицательных значений.*/
            // Генерация массива из 30 элементов с ростом учеников.
            int[] heights = new int[30];
            Random rnd = new Random();

            for (int i = 0; i < heights.Length; i++)
            {
                // Случайные отрицательные значения (рост мальчиков) и положительные (рост девочек)
                if (rnd.Next(2) == 0)
                {
                    heights[i] = -rnd.Next(140, 200); // Рост мальчиков от -140 до -199
                }
                else
                {
                    heights[i] = rnd.Next(140, 200); // Рост девочек от 140 до 199
                }
            }

            int boysCount = 0, girlsCount = 0;
            int boysSum = 0, girlsSum = 0;

            // Подсчет количества мальчиков и девочек, а также суммирование их роста
            foreach (var height in heights)
            {
                if (height < 0) // Если рост отрицательный, это мальчик
                {
                    boysCount++;
                    boysSum += Math.Abs(height); // Суммируем абсолютные значения
                }
                else // Если рост положительный, это девочка
                {
                    girlsCount++;
                    girlsSum += height;
                }
            }

            // Вычисление среднего роста
            double boysAverage = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double girlsAverage = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            // Вывод результатов
            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Средний рост мальчиков: {boysAverage:F2} ");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост девочек: {girlsAverage:F2} ");

            // Для примера - вывод массива ростов
            Console.WriteLine("\nРост учеников:");
            foreach (var height in heights)
            {
                Console.Write("\t" + height);
            }

        }

        }
    }

