using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd2laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ваш вік: ");
            int k = int.Parse(Console.ReadLine()); // Зчитуємо введене число

            if (k % 10 == 1 && k % 100 != 11)
            {
                Console.WriteLine($"Мені {k} рік");
            }
            else if (k % 10 >= 2 && k % 10 <= 4 && !(k % 100 >= 12 && k % 100 <= 14))
            {
                Console.WriteLine($"Мені {k} роки");
            }
            else
            {
                Console.WriteLine($"Мені {k} років");
                Console.ReadKey();
            }
        }
    }
}
