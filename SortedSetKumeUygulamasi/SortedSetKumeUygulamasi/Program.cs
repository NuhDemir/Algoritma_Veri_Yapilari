using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetKumeUygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SortedSet Küme İşlemleri
           // var A = new SortedSet<int>() { 1, 2, 3, 4 };
           var A = new SortedSet<int>(RandomNumberGenerated(20));
            var B = new SortedSet<int>() { 1, 2, 5, 6 };

            Console.WriteLine();
            Console.WriteLine("A Kümesi : ");

            #region
            foreach (int n in A)
            {
                Console.WriteLine($"{n,5}");
                Console.WriteLine("---");
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("B Kümesi : ");


            foreach (int n in B)
            {
                Console.WriteLine($"{n,5}");
                Console.WriteLine("---");
            }

            Console.WriteLine();
            #endregion


            //Union
            Console.WriteLine("A ve B kümesinin Birleşimi");
            A.UnionWith(B);
            foreach (var item in A)
            {
                Console.WriteLine($"{item,4}");
            }

            Console.WriteLine("Toplam Sayısı : {0}", A.Count);


            Console.ReadKey();

        }
        static List<int> RandomNumberGenerated(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            

                list.Add(r.Next(0, 1000));
                return list;

            

        }
    }

     }

    

