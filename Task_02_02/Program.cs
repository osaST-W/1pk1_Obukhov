namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Найти значение выражения при a = 8, b = 14, с = π/4
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;
            double part1 = Math.Sqrt(Math.Pow(a - 1, 3));
            double part2 = Math.Sqrt(Math.Pow(b + part1, 4));
            double part3 = Math.Abs(a - b);
            double part4 = Math.Pow(Math.Abs(c), 2);
            double part5 = Math.Tan(c);
            double part6 = part4 + part5;
            double part7 = (part2 / part4 * part6);
            Console.WriteLine(part7);

        }
    }
}
