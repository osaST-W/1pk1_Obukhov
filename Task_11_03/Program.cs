namespace Task_11_03
{
    internal class Program
    {// Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
     // выходной параметр количество гласных и согласных букв в этой строке
        static void Main (string[] args)
        {
            string input = "Привет, мир!";
            int vCount, cCount;

            CountLetters(input, out vCount, out cCount);

            Console.WriteLine($"Количество гласных: {vCount}");
            Console.WriteLine($"Количество согласных: {cCount}");
        }

        static void CountLetters(string input, out int vCount, out int cCount)
        {
            vCount = 0;
            cCount = 0;
            string vowels = "аеiouyАЕИОУЫЯЮЭЁAEIOUYaeiouy"; // Гласные буквы (русские и английские)

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    if (vowels.Contains(ch))
                    {
                        vCount++;
                    }
                    else
                    {
                        cCount++;
                    }
                }
            }

        }
    }
}
