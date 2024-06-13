using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable Uygulaması
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();

            //kucultme
            baslik = baslik.ToLower();

            //HashTable->Manipüle etmek istediğimiz karakterleri tanımlayacağız
            var karakterSeti = new Hashtable()
            {
                //Key-Value tanımlamaları bir defa kullanılır.
                {'ç','c' },
                {'ı','i' },
                {'ö','o' },
                {'ü','u' },
                {' ','_' },
                {'\'','_' },
                {'ğ','g' },
                {'.','_' },

            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                //(char) veya() parantez içine data type olarak gelen ifadeler cast işlemidir.
                //cast işlemi objelerde kullanılır.
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            //Ekrana Yazdırma
            Console.WriteLine(baslik);
            Console.ReadKey();
        }
    }
}
