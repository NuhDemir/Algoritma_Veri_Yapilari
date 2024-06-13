using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Repetition
{
//Sınıflar aynı namespace içerisinde erişilebilir.




    public class Lecturer
    {
        //prop ifadesi özellik kullanımı için kullanılır.
        public int LecturerNo { get; set; }
        //property
        public string Name { get; set; }
        //property
        public bool Gender { get; set; }

        //Default Constructor-ctor
        public Lecturer()
        {

        }

        //Yapılandırıcı methot-Overloading yapıyoruz
        public Lecturer(int lecturerNo, string name, bool gender)
        {
            LecturerNo = lecturerNo;
            Name = name;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{LecturerNo} " +
                   $"{Name} " +
                  string.Format("{0}", Gender == true ? " Bay" : "Bayan" );
        }
    }
}
