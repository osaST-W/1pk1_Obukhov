namespace Task_11_01
{
    internal class Program
    {
       // Передача по значению: Напишите метод, который принимает два целых числа и меняет их
       // местами.Проверьте, изменились ли значения переменных вне метода
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Перед заменой: a = {a}, b = {b}");
            Swap(a, b); // Вызов метода с передачей по значению
            Console.WriteLine($"После замены (без ссылки): a = {a}, b = {b}");

            // Теперь используем передачу по ссылке
            SwapRef(ref a, ref b);
            Console.WriteLine($"После замены (с ссылкой): a = {a}, b = {b}");
        }

        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void SwapRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


    }
    }

