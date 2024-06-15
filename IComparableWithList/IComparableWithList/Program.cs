using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableWithList
{

    //ICıty bir kontrattır.
    //public interface ICıty
    //{
    //    void Tanitim();
    //    void NufusBilgisiGetir(int plakaNo);
    //}

    public class City :IComparable<City>
    {


        public int PlakaNo { get; set; }
        public string CityName { get; set; }
        public City(int plakaNo, string cityName)
        {
            PlakaNo = plakaNo;
            CityName = cityName;
        }

        public override string ToString()
        {
            return $"{PlakaNo,-5} {CityName,-15}";
        }

        public int CompareTo(City other)
        {
            if (this.PlakaNo<other.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo==other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //public void Tanitim()
        //{
        //    throw new NotImplementedException("Tanıtım implement edilmedi!");
        //}

        //public void NufusBilgisiGetir(int plakaNo)
        //{
        //    throw new NotImplementedException("Nüfus Bilgisi Getirilmedi!");
        //}
    }
    public class Program
    {

        static void Main(string[] args)
        {
            //List
            var numbers = new List<int>() { 26, 43, 34, 12, 1, 87, 123, 32, 65, 3 };
            numbers.Sort();

            numbers.ForEach(s => Console.WriteLine(s + ", "));

            //Şehir Listesi
            var citys = new List<City>()
            {
              new City(6, "Ankara"),
    new City(34, "İstanbul"),
    new City(26, "Eskişehir"),
    new City(55, "Samsun"),
    new City(23, "Elazığ"),
    new City(44, "Malatya"),
    new City(1, "Adana"),
    new City(2, "Adıyaman"),
    new City(3, "Afyonkarahisar"),
    new City(4, "Ağrı"),
    new City(5, "Amasya"),
    new City(7, "Antalya"),
    new City(8, "Artvin"),
    new City(9, "Aydın"),
    new City(10, "Balıkesir"),
    new City(11, "Bilecik"),
    new City(12, "Bingöl"),
    new City(13, "Bitlis"),
    new City(14, "Bolu"),
    new City(15, "Burdur"),
    new City(16, "Bursa"),
    new City(17, "Çanakkale"),
    new City(18, "Çankırı"),
    new City(19, "Çorum"),
    new City(20, "Denizli"),
    new City(21, "Diyarbakır"),
    new City(22, "Edirne"),
    new City(24, "Erzincan"),
    new City(25, "Erzurum"),
    new City(27, "Gaziantep"),
    new City(28, "Giresun"),
    new City(29, "Gümüşhane"),
    new City(30, "Hakkâri"),
    new City(31, "Hatay"),
    new City(32, "Isparta"),
    new City(33, "Mersin"),
    new City(35, "İzmir"),
    new City(36, "Kars"),
    new City(37, "Kastamonu"),
    new City(38, "Kayseri"),
    new City(39, "Kırklareli"),
    new City(40, "Kırşehir"),
    new City(41, "Kocaeli"),
    new City(42, "Konya"),
    new City(43, "Kütahya"),
    new City(45, "Manisa"),
    new City(46, "Kahramanmaraş"),
    new City(47, "Mardin"),
    new City(48, "Muğla"),
    new City(49, "Muş"),
    new City(50, "Nevşehir"),
    new City(51, "Niğde"),
    new City(52, "Ordu"),
    new City(53, "Rize"),
    new City(54, "Sakarya"),
    new City(56, "Siirt"),
    new City(57, "Sinop"),
    new City(58, "Sivas"),
    new City(59, "Tekirdağ"),
    new City(60, "Tokat"),
    new City(61, "Trabzon"),
    new City(62, "Tunceli"),
    new City(63, "Şanlıurfa"),
    new City(64, "Uşak"),
    new City(65, "Van"),
    new City(66, "Yozgat"),
    new City(67, "Zonguldak"),
    new City(68, "Aksaray"),
    new City(69, "Bayburt"),
    new City(70, "Karaman"),
    new City(71, "Kırıkkale"),
    new City(72, "Batman"),
    new City(73, "Şırnak"),
    new City(74, "Bartın"),
    new City(75, "Ardahan"),
    new City(76, "Iğdır"),
    new City(77, "Yalova"),
    new City(78, "Karabük"),
    new City(79, "Kilis"),
    new City(80, "Osmaniye"),
    new City(81, "Düzce")
            };

            Console.WriteLine("--------------------------");
            
            citys.Sort();
            citys.ForEach(s => Console.WriteLine(s));




            Console.ReadKey();
        }
    }
}
