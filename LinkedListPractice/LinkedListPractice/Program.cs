using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              LinkedList:

             LinkedList, System.Collections.Generic sınıfına aittir.
             Generic bir veri yapısıdır, bu yüzden tür güvenlidir (Type-Safe).
             Boxing/Unboxing yoktur, yani performans kaybı yaşanmaz.
             Doğrusal bir veri yapısıdır.

             LinkedList'in Avantajları:
             1. Dinamik boyut: LinkedList, eleman ekleme ve çıkarma işlemlerinde esnektir. Bellek kullanımı gerektiği gibi artar ve azalır.
             2. Kolay eleman ekleme/çıkarma: Liste başına ve sonuna eleman eklemek/çıkarmak O(1) zaman karmaşıklığı ile yapılabilir.
             3. Sıralı erişim: Elemanlara sıralı erişim imkanı sağlar. Özellikle kuyruk ve yığın veri yapılarının uygulanmasında kullanışlıdır.

             LinkedList'in Dezavantajları:
             1. Rastgele erişim yok: Dizilerde olduğu gibi O(1) zaman karmaşıklığı ile rastgele bir elemana erişim sağlanamaz. Bir elemana erişmek için O(n) zaman karmaşıklığı gereklidir.
             2. Ek bellek kullanımı: Her düğüm, bir veri ve bir sonraki düğüme işaret eden bir gösterici (pointer) içerir, bu da ek bellek kullanımı anlamına gelir.
             3. Sürekli bellek tahsisi ve serbest bırakma: LinkedList'in dinamik yapısı, sürekli bellek tahsisi ve serbest bırakma işlemlerine neden olur, bu da yönetim maliyetlerini artırır.

             LinkedList Nerede Kullanılır:
             1. Yığın (Stack) ve Kuyruk (Queue) veri yapılarının uygulanmasında kullanılır.
             2. Listeye sıkça ekleme ve çıkarma işlemlerinin yapıldığı durumlarda tercih edilir.
             3. Dinamik veri yapıları gerektiren uygulamalarda kullanılır.
             4. Undo (geri alma) fonksiyonlarının uygulanmasında kullanılır, çünkü liste başına ve sonuna hızlı erişim sağlar.
             5. Dairesel listeler ve çift yönlü bağlı listeler gibi özel bağlı liste türlerinin uygulanmasında kullanılır.

            */

            //Tanımlama
            var cities = new LinkedList<string>();


            // 30 Amerika şehri ekleyelim
            cities.AddFirst("Antalya");
            
            cities.AddFirst("İzmir");
            cities.AddFirst("Samsun");
            cities.AddAfter(cities.Find("İzmir"),"Eskişehir");
            cities.AddFirst("Adıyaman");
            cities.AddFirst("Denizli");
            cities.AddLast("Bartın");
            cities.AddBefore(cities.First.Next.Next.Next, "Malatya");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı :");
            var factors = cities.First;
            while(factors != null )
            {
                
                Console.WriteLine($"-> {factors.Value}");
                factors = factors.Next;
            }
            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı :");
            var temp = cities.First;
            while (temp != null)
            {

                Console.WriteLine($"-> {temp.Value}");
                temp = temp.Previous;
            }
            // Şehirleri ekranda yazdıralım
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            Console.ReadKey();
        }
    }
}
