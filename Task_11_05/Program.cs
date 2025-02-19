namespace Task_11_05
{
    internal class Program
    {//Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
     //возвращает их сумму и произведение через выходные параметры(out)
        static void Main( string[] args)
        {
            int a = 5;
            int b = 3;
            int sum, product;

            Calculate(a, b, out sum, out product);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }

        static void Calculate(ref int num1, ref int num2, out int sum, out int product)
        {
            sum = num1 + num2;
            product = num1 * num2;

            // Обновляем значения num1 и num2, чтобы показать работу ref
            num1++;
            num2++;

        }
    }
}
