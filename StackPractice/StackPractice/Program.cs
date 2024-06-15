using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Yığın Temelleri
             
                 push: ekleme
                 pop: çıkarma
                 pick : çalıştığı anda işlem görecek eleman
                 clear : temizleme
                 count : eleman sayısı
                 ToArray: diziye dönüştürme
                 Doğrusal bir veri yapısı
                 -------------------------
                Nerede Kullanılır:

                Fonksiyon çağrılarında ve özyinelemeli(rekürsif),
                İşletim Sistemi üzerinde en son kullanılan uygulamarın listesini tutma
                Söz dizilimi(syntax) hatalarını yakalama,
                geri izleme işlemlerinde,
                ayrıştırma(parsing),
                Ters Çevirme,Hafıza Yönetimi,
                Tarayıcı sekmelerinde kullanılabilir
          
             */

            StackExample();
            var charachterExample = new Stack<char>();

            for (int i = 65; i <= 90; i++)
            {
                charachterExample.Push((char)i);
                Console.WriteLine($"{charachterExample.Peek(),-5} | yığına eklendi.");
                Console.WriteLine("---");
                Console.WriteLine($"Yığındaki eleman sayısı : {charachterExample.Count}");
                Console.WriteLine("---");
            }
            var dizi = charachterExample.ToArray();
            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız.");
            while (charachterExample.Count > 0)
            {
                Console.WriteLine($"{charachterExample.Pop(),-8} yığından çıkarıldı.");
            }

            Console.ReadKey();


        }

        private static void StackExample()
        {
            //Stack Tanımlama
            var charachterStack = new Stack<char>();
            //Ekleme
            charachterStack.Push('A');
            Console.WriteLine(charachterStack.Peek());
            charachterStack.Push('B');
            Console.WriteLine(charachterStack.Peek());
            charachterStack.Push('C');
            Console.WriteLine(charachterStack.Peek());
            charachterStack.Push('D');
            Console.WriteLine(charachterStack.Peek());
            charachterStack.Push('E');
            Console.WriteLine(charachterStack.Peek());

            //Çıkarma
            Console.WriteLine(charachterStack.Pop() + " elemanı yığından çıkartıldı.");
            Console.WriteLine(charachterStack.Pop() + " elemanı yığından çıkartıldı.");
            Console.WriteLine(charachterStack.Pop() + " elemanı yığından çıkartıldı.");
            Console.WriteLine(charachterStack.Pop() + " elemanı yığından çıkartıldı.");
            Console.WriteLine(charachterStack.Pop() + " elemanı yığından çıkartıldı.");
        }
    }
}
