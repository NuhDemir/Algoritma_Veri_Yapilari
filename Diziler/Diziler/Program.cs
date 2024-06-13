using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array|Dizi
            int[] number1 = new int[] { 1, 2, 3, 4, 5, 8, 11, 44, 25, 34, 48, 26 };
            var number2 = Array.CreateInstance(typeof(int), 5);
            var arr = new ArrayList(number1);

            number2.SetValue(5, 0);
            number2.SetValue(11, 1);
            number2.SetValue(9, 2);
            number2.SetValue(13, 3);
            number2.SetValue(88, 4);

            for (int i = 0; i < number1.Length; i++)
            {
                number2.SetValue(number1[i], i);
            }

            for (int i = 0; i < number2.Length; i++)
            {
                Console.WriteLine($"number1[{i}] = " +
                    $"{number1[i],3} - " +
                    $"number2[{i}] = " +
                    $"{number2.GetValue(i),3} " +
                    $"arr[{i}] = " +
                    $"{arr[i],3}");
            }


            Console.WriteLine();

            //Dizinin uzunluğunu (eleman sayısını) ekrana yazdırıyoruz
            Console.WriteLine("Length = " + number1.Length);
            Console.WriteLine();

            //Diziyi Sıralamak istersek...
            Array.Sort(number1);
            Console.WriteLine("Sorted(Sıralama) = " + string.Join(", ", number1));
            Console.WriteLine(); ;

            //Diziyi tersine çevirir.
            Array.Reverse(number1);
            Console.WriteLine("Reversed = " + string.Join(", ", number1));
            Console.WriteLine();

            //Belirtilen değerin dizideki ilk indeksini döner.
            int index = Array.IndexOf(number1, 3);
            Console.WriteLine("Index of 3 = " + index);
            Console.WriteLine();

            //Bir dizinin belirli bir kısmını başka bir diziye kopyalar.
            Array.Copy(number1, 1, number2, 0, 3);
            Console.WriteLine("Copied = " + string.Join(", ", number2));
            Console.WriteLine();

            //Dizinin belirli bir bölümünü sıfırlar (varsayılan değerine ayarlar).
            Array.Clear(number1, 1, 3);
            Console.WriteLine("Cleared = " + string.Join(", ", number2));
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
