namespace Task_02__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
            //расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
            //этом 


            Console.Write("Год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("День: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime b = new DateTime(year, month, day); // День рождения
            DateTime s = DateTime.Now; // Данный момент времени
            int age = s.Year - b.Year; // Возраст

            if (s.Month < b.Month || s.Month == b.Month && s.Day < b.Day)
            {
                age--;
            }
            if (age >= 18)
            {
                Console.WriteLine("Совершеннолетний");
            }
            else
            {
                Console.WriteLine("Несовершеннолетний");
            }
        }
    }
}
