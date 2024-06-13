using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HashTable_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hakkında
            /*
            Hashtable, anahtar-değer çiftlerine göre organize
            edilen non-generic bir koleksiyon sınıfıdır.

            Boxing ve unboxing işlemleri,
            değer türleri ile çalışırken otomatik olarak gerçekleşir.

            Indisleme yerine anahtarlar kullanılarak elemanlara erişilir.

            Hashtable, ICollection arayüzünü uygular ve anahtarlar ContainsKey,
            değerler ise ContainsValue metodları ile kontrol edilir.
            */




            var citys = new Hashtable();

            //Ekleme
            citys.Add(6, "Ankara");
            citys.Add(34, "İstanbul");
            citys.Add(55, "Samsun");
            citys.Add(26, "Eskişehir");

            //Dolaşım
            foreach (DictionaryEntry item in citys)
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,20} ");
            }
            Console.WriteLine("-----------------------------------");
            //Anahtarlara erişim sağlamak için
            Console.WriteLine("Anahtarlar(Keys) :");
            Console.WriteLine();
            var keys = citys.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine("[" + item + "]");
            }

            Console.WriteLine("-----------------------------------");
            //Değerler
            Console.WriteLine("Değerler :");
            Console.WriteLine();
            ICollection degerler = citys.Values;

            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------");

            //Değerlere Erişme
            Console.WriteLine("Elemana Erişme: ");
            Console.WriteLine(citys[6]);//Output: Ankara




            Console.ReadKey();
        }
    }
}
