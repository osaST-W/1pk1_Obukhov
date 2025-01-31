namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
              которых равны.*/
            int[] c = new int[50];
            Random rnd = new Random();
            
            for ( int i = 0; i < c.Length; i++ ) //внешний цикл
            {
                c[i] = rnd.Next();
                int s = i;
                if ( i == s) // внутренний цикл
                {
                    Console.WriteLine($"\t {s} | \t {i}");
                }
            }
        }
    }
}
