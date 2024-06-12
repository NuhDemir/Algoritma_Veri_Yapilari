using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTemelleri
{
    public class Listeleme
    {
        static void Main(string[] args)
        {
            var studentList = new List<Student>()
            { new Student(1,"Ali","Molla",true),
             new Student(2,"Turgut","Tezat",true),
             new Student(2,"Senem","İnan",false),
             new Student(2,"Feriha","Çolak",false),

            };

            foreach (Student o in studentList)
            {
                Console.WriteLine(o);
            }


        }
    }
}
