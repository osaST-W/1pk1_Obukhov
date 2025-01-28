namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 14;
            double a = 8;
            double c = Math.PI / 4;
            double part1 = Math.Pow(Math.Sqrt(a - 1), 3);
            double part2 = Math.Pow(Math.Sqrt(b + part1), 4);
            double part3 = Math.Abs(a - b);
            double part4 = Math.Pow(Math.Sin(c), 2);
            double part5 = part4 + Math.Tan(c);
            double part6 = part2 / part3 * part5;
            Console.WriteLine(part6);
        }
    }
}
