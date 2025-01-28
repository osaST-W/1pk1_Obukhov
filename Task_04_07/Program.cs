using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_07

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // используем HashSet для хранения уникальных чисел 
            HashSet<int> IC = new HashSet<int>();
            Random rnd = new Random();
            int R;
            {
                while (IC.Count > 0)     // Знвчения роста девочек
                {
                    R  = rnd.Next(160, 181); // выпапдение сулчайного числа в заданном диапозоне
                    Console.WriteLine(R);
                    
                }

                
            }



            {

                
            }
        }
    }
}

