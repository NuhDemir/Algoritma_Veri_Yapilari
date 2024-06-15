using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             SortedDictionary:

             SortedDictionary, System.Collections.Generic sınıfına aittir.
             Generic bir koleksiyon sınıfıdır, bu nedenle tür güvenlidir.
             
             SortedDictionary, anahtar-değer (key-value) çiftleri şeklinde veri saklar ve anahtarlarına göre sıralar.
             Anahtarlar sıralı bir şekilde tutulur, bu da verilerin sıralı bir şekilde erişimini sağlar.
             
             SortedDictionary'in Avantajları:
             1. Sıralı veri saklama: Anahtarlar sıralı olarak saklandığı için verilerin sıralı bir şekilde erişilmesini sağlar.
             2. Hızlı arama: Anahtar üzerinden hızlı arama işlemleri yapılabilir.
             3. Tür güvenliği: Generic olduğu için tür güvenliğidir ve boxing/unboxing işlemleri gerekmez.

             SortedDictionary'in Dezavantajları:
             1. Bellek kullanımı: Her giriş için hem anahtar hem de değer saklandığı için bellek kullanımı artabilir.
             2. Performans: Eklemeler ve silmeler sıralı bir yapıda gerçekleştiği için performans, normal Dictionary sınıfına göre daha yavaş olabilir.

             SortedDictionary Nerede Kullanılır:
             1. Anahtarlar üzerinde sıralı erişim gerektiğinde.
             2. Sıralı veri saklama ve hızlı arama işlemleri gerektiğinde.
             3. Kitap indeksleme, rehberler, sıralı veri saklama gerektiren uygulamalarda kullanılır.

             */

            var bookIndex = new SortedDictionary<string, List<int>>()
            {
                {"HTML",new List<int>(){8,10,12 } },
                {"CSS",new List<int>(){70,80,90 } },
                {"jQuery",new List<int>(){3,5,15 } },
                {"SQL",new List<int>(){70,80} },
            };

            // Yeni veri ekleme
            bookIndex.Add("JavaScript", new List<int>() { 20, 25, 30 });
            bookIndex["Python"] = new List<int>() { 40, 50, 60 }; // Alternatif ekleme yöntemi

            // Var olan bir anahtarın değerine yeni bir sayfa ekleme
            bookIndex["HTML"].Add(14);

            // Anahtar-değer çiftlerinin ekrana yazdırılması
            foreach (var concept in bookIndex)
            {
                Console.WriteLine(concept.Key);
                Console.WriteLine("-------------");
                concept.Value.ForEach(x => Console.WriteLine("\t ->" + "page: " + x));
            }

            // Anahtar kontrolü ve eleman silme
            if (bookIndex.ContainsKey("CSS"))
            {
                bookIndex.Remove("CSS");
                Console.WriteLine("CSS konusu ve ilgili sayfalar kaldırıldı.");
            }

            Console.WriteLine("\nGüncellenmiş Kitap İndeksi:");
            foreach (var concept in bookIndex)
            {
                Console.WriteLine(concept.Key);
                Console.WriteLine("-------------");
                concept.Value.ForEach(x => Console.WriteLine("\t ->" + "page: " + x));
            }

            Console.ReadKey();
        }
    }
}
