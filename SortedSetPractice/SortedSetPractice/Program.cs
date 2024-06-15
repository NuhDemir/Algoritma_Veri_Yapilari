using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* YORUM SATIRI :
              -Elemanları benzersiz olmalıdır.
                -Sıralı: Sıralama EKLEME sırasında yapılır.
                -Add(): Ekleme|bool döner.
                -Remove(): Silme
                -RemoveWhere(predicate)|predicate ifade: koşul ifadesi yazabilir
                 ve lambda ifade alabiliriz.
                -Dinamik bir veri yapısıdır.
                -Küme Teorisini destekler. Kümelerdeki kesişim ifadesi
                    ->Ayrışım
                    ->Keşisim
                    ->Birleşim
                    ->Alt Kümeler
                    ifadeleri.
                
                KÜME:
                ----
                A kümesi: 1,2,3,4,5,6,7,8,9
                B kümesi: 7,8,9,10,11,12,13
            
                ->Kümelerin Birleşimi = A.UnionWith(B);{1,2,3...12,13}
                ->Kümelerin Kesişimi  = A.IntersectWith(B);{7,8,9}
                ->Kümelerin Ayrışımı  = A.ExceptWith(B);{1,2,3,4,5,6}
       */

            var list = new SortedSet<string>();

            //Ekleme
            if(list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi!");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız!");
            }
            Console.WriteLine("{0}",list.Add("Ahmet") ==true ? "Ahmet Eklendi":"Ekleme başarısız!");

            list.Add("Şule");
            list.Add("Neslihan");
            list.Add("Cemal");
            list.Add("Avni");
            list.Add("Kerem");
            Console.WriteLine("---");
            //Silme
            list.Remove("Şule");
            list.RemoveWhere(deger => deger.Contains("a"));
            Console.WriteLine("---");

            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string item in list) {
                Console.WriteLine(item);

            }


            Console.ReadKey();

        }
    }
}
