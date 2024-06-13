using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList
            var bookContent = new SortedList();
            bookContent.Add(1, "Önsöz");
            bookContent.Add(50, "Değişkenler");
            bookContent.Add(40, "Operatörler");
            bookContent.Add(60, "Döngüler");
            bookContent.Add(45, "ilişkisel Operatörler");

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("İçindekiler : ");
            Console.WriteLine(new string('-', 20));

            Console.WriteLine($"{"Konular",10} {"Sayfalar",5}");

            foreach (DictionaryEntry item in bookContent)
            {
                Console.WriteLine($"{item.Value,-20} - {item.Key,5}");
            }
            Console.ReadKey();
        }
    }
}
