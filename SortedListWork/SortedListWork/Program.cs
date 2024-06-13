using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListWork
{
    public class Program
    {

            /* 
            SortedList:

            - `System.Collections` sınıfına aittir ve non-generic bir koleksiyon sınıfıdır.
            - Anahtar-Değer (Key-Value) çiftleri ile çalışır.

            Sıralama:
            - Anahtarlar (Keys) sıralı olarak tutulur. Elemanlar eklendiğinde, anahtarlarına göre sıralı olarak organize edilirler.
            - Hem anahtarlar (Key) hem de indekslerle elemanlara erişmek mümkündür.
            */
            /* Metodlar ve Özellikler:
             - `IndexOfKey`: Belirli bir anahtarın indeksini döner. Anahtarı alıp, o anahtarın hangi indeks değerine sahip olduğunu bulabiliriz.
               SortedList sortedList = new SortedList();
               sortedList.Add(3, "Three");
               sortedList.Add(1, "One");
               sortedList.Add(2, "Two");
               int index = sortedList.IndexOfKey(2); // index = 1
          */
            /*
            - `IndexOfValue`: Belirli bir değerin indeksini döner. İlgili değerin hangi indekste olduğunu bulabiliriz.
              ```csharp
              int valueIndex = sortedList.IndexOfValue("Two"); // valueIndex = 1
              ```

            - `GetKey`: Belirli bir indeksin anahtarını döner. Örneğin, listedeki 0'ıncı elemanın anahtar değeri nedir sorusuna bu metotla cevap bulabiliriz.
              ```csharp
              var key = sortedList.GetKey(0); // key = 1
              ```

            - `GetByIndex`: Belirli bir indeksin değerini döner. Örneğin, listedeki 0'ıncı elemanın değerini bu metotla bulabiliriz.
              ```csharp
              var value = sortedList.GetByIndex(0); // value = "One"
              ```

            - `DictionaryEntry`: Her bir elemanın anahtar-değer çiftlerini temsil eden bir yapı. Bu yapı, listedeki her bir elemanın organizasyonunu yönetir.
              ```csharp
              foreach (DictionaryEntry entry in sortedList)
              {
                  Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
              }
              ```

            - `IComparer` arayüzünü uygular. Anahtarların sıralanmasında kullanılan karşılaştırma işlemlerini tanımlamak için kullanılır.
              ```csharp
              SortedList sortedListWithComparer = new SortedList(new CustomComparer());
              sortedListWithComparer.Add(3, "Three");
              sortedListWithComparer.Add(1, "One");
              sortedListWithComparer.Add(2, "Two");

              public class CustomComparer : IComparer
              {
                  public int Compare(object x, object y)
                  {
                      return ((int)x).CompareTo((int)y);
                  }
              }
              ```

            Örnek Kullanım:
            ```csharp
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");

            // Elemanlara erişim
            Console.WriteLine(sortedList[1]); // "One"
            Console.WriteLine(sortedList.GetByIndex(0)); // "One"
            Console.WriteLine(sortedList.GetKey(0)); // 1

            // Tüm elemanları listeleme
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.ReadKey();
            ```

            Bu açıklamalar ve örneklerle, `SortedList` yapısının temel özellikleri ve kullanımı hakkında daha detaylı bir anlayışa sahip olabilirsiniz.
            */
        }
    }
