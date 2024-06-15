using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sesli harfler listesini tanımlıyoruz
            var vowels = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            // Kuyruk oluşturuyoruz
            var kuyruk = new Queue<char>();

            // vowSelect değişkenini tanımlıyoruz
            ConsoleKeyInfo vowSelect;

            foreach (char k in vowels)
            {
                Console.WriteLine($"{k,-5} harfi kuyruğa eklensin mi? [e/h] ");
                // Kullanıcıdan giriş alıyoruz
                vowSelect = Console.ReadKey();
                Console.WriteLine();

                if (vowSelect.Key == ConsoleKey.E)
                {
                    // Kullanıcı 'e' tuşuna basarsa harfi kuyruğa ekliyoruz
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} harfi kuyruğa eklendi");
                    Console.WriteLine($"Kuyruktaki harf sayısı : {kuyruk.Count}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.Write("Kuyruktan elemanların kaldırılması için ESC tuşuna basınız.");
            vowSelect = Console.ReadKey();

            if (vowSelect.Key == ConsoleKey.Escape)
            {
                while (kuyruk.Count > 0)
                {
                    // Kuyruktaki ilk elemanı görüntülüyoruz ve sonra çıkartıyoruz
                    Console.WriteLine($"{kuyruk.Peek(),5} harfi kuyruktan çıkartılıyor...");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
                    Console.WriteLine($"Kuyruktaki harf sayısı : {kuyruk.Count}");
                }
                Console.WriteLine("\nKuyruktan harf çıkarma işlemi tamamlandı.");
            }

            Console.ReadKey();
        }
    }
}
