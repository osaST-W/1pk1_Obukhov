using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = rnd.Next(20);
                Console.WriteLine(c[i]);
            }
        }
    }
}

