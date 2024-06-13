using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SortedListWork
{
    public class SortedListTemelleri
    {
        static void Main(string[] args)
        {
            // SortedList koleksiyonu oluşturuluyor.
            // SortedList anahtar-değer çiftlerini tutar ve anahtarlarına göre sıralı şekilde saklar.
            var list = new SortedList();

            // Anahtar-değer çiftleri ekleniyor. Anahtarlara göre otomatik olarak sıralanacaklar.
            list.Add(1, "Bir");
            list.Add(2, "İki");
            list.Add(7, "Yedi");
            list.Add(3, "Üç");
            list.Add(11, "Onbir");
            list.Add(4, "Dört");

            // Tüm anahtar-değer çiftlerini yazdır.
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("--------------------------");

            // Listedeki eleman sayısını yazdır.
            Console.WriteLine("Listedeki Eleman Sayısı : {0}", list.Count);

            // Listenin kapasite bilgisini yazdır.
            Console.WriteLine("Listenin Kapasite Bilgisi : {0}", list.Capacity);

            // TrimToSize metodu kapasiteyi, eleman sayısına düşürür.
            list.TrimToSize();
            Console.WriteLine("Listenin Kapasite Bilgisi (TrimToSize sonrası) : {0}", list.Capacity);
            Console.WriteLine("--------------------------");

            // Belirli bir anahtarın değerine erişim.
            Console.WriteLine("Key Değerine Erişme : ");
            Console.WriteLine(list[4]);
            Console.WriteLine("--------------------------");

            // Belirtilen indexteki değeri getir.
            Console.WriteLine("Belirtilen Indexteki Key değerini getir : ");
            Console.WriteLine(list.GetByIndex(1));
            Console.WriteLine("--------------------------");

            // Belirtilen indexteki anahtar değerini getir.
            Console.WriteLine(list.GetKey(0));
            Console.WriteLine("--------------------------");

            // Listenin sonundaki elemanın değerini getir.
            Console.WriteLine("Liste sonundaki elemanın değeri : ");
            Console.WriteLine(list.GetByIndex(list.Count - 1));

            // Tüm anahtarları yazdır.
            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // Tüm değerleri yazdır.
            var degerler = list.Values;
            Console.WriteLine("\nDegerler");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            // Anahtar olup olmadığını kontrol et ve varsa değeri güncelle.
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }

            // Güncellenmiş anahtar-değer çiftlerini yazdır.
            Console.WriteLine("\nGüncellenmiş Liste");
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            // Programı sonlandırmak için kullanıcıdan bir tuşa basmasını bekle.
            Console.ReadKey();
        }
    }
}
