namespace Task_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны натуральные числа от 20 до 50.Напечатать те из них, которые делятся на 3, но не делятся на 5.
            int[] n = new int[51]; // создание челочисленного массива
            Random rnd = new Random();
            for ( int i = 20; i <n.Length; i++) // внешний цикл
            {
                n[i] = rnd.Next(20, 51); //диапозон значений

                if ( i % 3 == 0 && i % 5 !=0) // условия кратности
                {
                    Console.WriteLine(i);
                }
                
            }
            
            

          


        }
    }
}
