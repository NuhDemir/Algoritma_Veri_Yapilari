using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Refernces
{
    internal class Lecturer
    {
        public int LecturerNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }


        public Lecturer()
        {

        }

        public Lecturer(int LecturerNo, string Name, string LastName, bool Gender)
        {
            this.LecturerNo = LecturerNo;
            this.Name = Name;
            this.LastName = LastName;
            this.Gender = Gender;

        }

        public override string ToString()
        {
            return $"{LecturerNo} " +
                $"{Name} " +
                $"{LastName} " +
                string.Format("{0}", Gender == true ? " Erkek" : "Kadın");
        }

    }
}
