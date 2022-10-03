using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMinMaxPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Present date.
            DateTime czas = DateTime.Now;
            Console.WriteLine(czas.Day + "." + czas.Month + "." + czas.Year);
            Console.WriteLine();

            // Min, Max, Sum
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int x = random.Next(1, 100);
                list.Add(x);
            }
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Sum());

            // Palindrom.
            Console.WriteLine("Input single word:");
            var IsPalindrom = Console.ReadLine();
            int qty = IsPalindrom.Length;
            int IsZero = 0;
            for (int i = 0; i < qty; i++)
            {
                if (IsPalindrom[i] == IsPalindrom[qty - 1 - i])
                {
                    IsZero = IsZero + 0;
                }
                else
                {
                    IsZero = IsZero + 1;
                }
            }

            if (IsZero == 0)
            {
                Console.WriteLine(IsPalindrom + " jest Palindromem");
            }
            else
            {
                Console.WriteLine(IsPalindrom + " nie jest Palindromem");
            }
        }
    }
}
