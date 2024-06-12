using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVeriYapısıTemelleri
{

    //Struct yapısı tanımlıyoruz
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        //Default Constructor
        //Struct yapısında kullanamıyoruz fakat class'larda kullanabiliriz
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        //Yapımıza yeni üye ekleyelim -> Metot
        public void SetOrigin()
        {
            this.X = 0;
            this.Y = 0;
        }

        //Bir metod daha, geriye değer dönmesin burada da
        public void ChancesPoint()
        {
            var temp = X;
            X = Y;
            Y = temp;

        }

    }



    public class Program
    {
        static void Main(string[] args)
        {
            //struct-değer tipi
            var n1 = new Point(5, 6);
            n1.ChancesPoint();


            var n2 = n1;
            //Manuel bir değişiklik yapıyoruz.
            n2.X = -1 * n2.X;
            Console.WriteLine($"n1 :  {n1}");
            Console.WriteLine($"n2 :  {n2}");

            //Konsol Ekranı Kapanmasın
            Console.ReadKey();

        }
    }
}
