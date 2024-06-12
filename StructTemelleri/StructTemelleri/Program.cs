using System;

namespace StructTemelleri
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Struct örneği oluşturma:
            Student student = new Student();

            // Struct örneğine değer atama:
            student.StudentNo = 20;
            student.Name = "Ethan";
            student.LastName = "Gauss";
            student.Gender = true;
            //Ekrana Yazdıralım...
            //Console.WriteLine($"{student.StudentNo} "
            //    + $"{student.Name} "
            //    + $"{student.LastName} "
            //    + $"{student.Gender}");

            /*Alternatif kullanım-2*/

            var student2 = new Student()
            {
                StudentNo = 10,
                Name = "Orion",
                LastName = "Glen",
                Gender = false
            };

            //Console.WriteLine($"{student2.StudentNo} " +
            //                  $"{student2.Name} " +
            //                  $"{student2.LastName} " +
            //                  $"{student2.Gender}");




            /*Alternatif kullanım-3*/
            var student3 = new Student(30, "Mehmet", "Avşar", false);
            var student4 = new Student(20, "Ali", "Somak", true);
            

            //Console.WriteLine($"{student3.StudentNo} " +
            //                  $"{student3.Name} " +
            //                  $"{student3.LastName} " +
            //                  $"{student3.Gender}");

            Console.WriteLine(student);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.WriteLine(student4);



            // Console.ReadKey() ile programın kapanmasını engelliyoruz.

            Console.ReadKey();
        }
    }
}