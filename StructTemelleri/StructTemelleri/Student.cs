using System;

namespace StructTemelleri
{
    public struct Student
    {
        //Metotların varsayılan değeri olabilir
        //Geri dönüş türü olmadığı için new anahtar kelimesiyle bir nesne üretildiğinde çalışır...
       //Yapılandırıcı Metot -Constructor
        public Student(int studentNo, string name, string lastName, bool gender)
        {
          
            StudentNo = studentNo;
            Name = name;
            LastName = lastName;
            Gender = gender;
        }

        // Struct'ın açıklaması:
        // Struct, birden fazla veri türünü bir araya getirerek yeni bir veri türü oluşturmak için kullanılır.
        // Struct içerisindeki tüm üyeler varsayılan olarak public erişim belirleyicisine sahiptir.

        // Property (özellik) tanımı:
        // Bu örnekte, struct içinde bir özellik (property) tanımladık.
        // Özellikler, veri kapsüllemeyi sağlar ve get/set metodları ile değeri okuma/yazma işlemleri yapar.
        public int StudentNo { get; set; } // Property - Özellik
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }


        //Override-Geçersiz Kılma-Ezmek
        
            public override string ToString()
        {
            return $"{StudentNo} {Name} {LastName}" +
                $"{(Gender == true ? "Erkek" : "Kadın") }";
        }

    }
}