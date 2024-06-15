using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
   - System.Collections.Generic sınıfında yer alır.
   - Generic: Boxing, Unboxing bulunmaz
   - T -> Type (Tip)
   - FIFO: First In First Out (ilk gelen ilk çıkar)

   Metodlar:
   - Enqueue: Kuyruğun sonuna bir öğe ekler.
   - Dequeue: Kuyruğun başından bir öğeyi kaldırır ve döndürür.
   - Peek: Kuyruğun başındaki öğeyi kaldırmadan döndürür.
   - Count: Kuyruktaki toplam öğe sayısını döndürür.
   - Clear: Kuyruğu temizler, tüm öğeleri kaldırır.
   - Contains: Belirtilen öğenin kuyrukta olup olmadığını kontrol eder.
   - ToArray: Kuyruğun öğelerini yeni bir diziye kopyalar.
   
   Kullanım Alanları:
   1. Yazıcı Sıraları: Bir yazıcıya gönderilen belgeler, sıralı bir şekilde yazdırılır.
   2. Müşteri Hizmetleri: Çağrı merkezinde müşterilerin sırayla hizmet alması.
   3. Görev Yönetimi: İşletim sistemlerinde veya yazılımlarda görevlerin sıralı bir şekilde işlenmesi.
   4. Trafik Yönetimi: Trafik ışıklarında araçların sırayla geçmesi.
   5. Bilet Satışı: Konser, sinema gibi etkinliklerde biletlerin sırayla satılması.
   
   Günlük Hayattan Örnek:
   - Market Kasası: Müşteriler kasada sıraya girer ve sırayla ödemelerini yapar.
   - Otobüs Kuyruğu: Yolcular, otobüse sırayla biner.
   - Yemekhane: Öğrenciler veya çalışanlar yemekhane kuyruğunda sırayla yemek alır.


            */
            var charQueue = new Queue<char>();

            //Ekleme
            charQueue.Enqueue('a');
            charQueue.Enqueue('b');
            charQueue.Enqueue('c');
            charQueue.Enqueue('d');
            charQueue.Enqueue('e');
            charQueue.Enqueue('f');
            charQueue.Enqueue('g');
            charQueue.Enqueue('h');
            charQueue.Enqueue('ı');
            charQueue.Enqueue('i');
            charQueue.Enqueue('j');
            charQueue.Enqueue('k');
            charQueue.Enqueue('m');
            Console.WriteLine("Harf sayısı : " + charQueue.Count);

            //Çıkarma
            Console.WriteLine($"Kuyruğun başındaki harf : {charQueue.Peek()}");//Kuyruğun başındaki elemanı döner.
            Console.WriteLine($"{charQueue.Dequeue()} | harfi kuyruktan çıkarıldı.");
            Console.WriteLine("Kalan Harf sayısı : " + charQueue.Count);

            Console.ReadKey();
        }
    }
}
