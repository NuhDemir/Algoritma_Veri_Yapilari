using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Refernces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama-atama
            var list1 = new List<Lecturer>()
            {
                new Lecturer(1,"Ahmet","Kanarya",true),
                new Lecturer(2,"Afşin","Uçar",false),
                new Lecturer(3,"Necla","Tekin",false),
                new Lecturer(4,"Neva","Ökse",false),
                new Lecturer(5,"Anıl","Turgut",true),
                new Lecturer(6,"Mert","Emin",true),


            };
            #region
            Console.WriteLine("Liste 1 : ");
            list1.ForEach(lect => Console.WriteLine(lect));
            Console.WriteLine();

            var list2 = list1;

            Console.WriteLine("Liste 2 : ");
            list2.ForEach(lect => Console.WriteLine(lect));
            Console.WriteLine();
            #endregion



            list2.Add(new Lecturer(7, "Ömer", "Altan", true));
            list1.RemoveAt(0);
            Console.WriteLine("Liste 2'ye Ekleme işlemi yapıldı...");
            Console.WriteLine();


            Console.WriteLine("Liste 1 : ");
            list1.ForEach(lect => Console.WriteLine(lect));
            Console.WriteLine();


            Console.WriteLine("Liste 2 : ");
            list2.ForEach(lect => Console.WriteLine(lect));
            Console.WriteLine();






            Console.ReadKey();
        }
    }
}
