using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lecturerList= new List<Lecturer>()
           {
               new Lecturer(1,"Ali",true),
           };
            //new anahtar sözcüğüyle birlikte sınıf ismini verdiğimiz zaman constructor çalışır.
            //Atama işlemleri
    foreach(Lecturer l in lecturerList)
            {
                Console.WriteLine(l);
            }
            
            Console.ReadKey();
        }
    }
}
