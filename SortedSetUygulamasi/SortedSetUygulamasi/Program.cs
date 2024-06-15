using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetUygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            //Rastgele sayılar üretiyoruz
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(r.Next(0,10));
                Console.WriteLine($"{numbers[i],-3}\n");
            }

            Console.WriteLine("-");

            //Listedeki benzersiz elemanları bulmak
            var uniqueNumber = new SortedSet<int>(numbers);
            Console.WriteLine();
            Console.WriteLine("Benzersiz Sayılar Listesi :\n");
            
            foreach (int i in uniqueNumber)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
