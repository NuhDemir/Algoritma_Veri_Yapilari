using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPracticw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            var telephoneCodes = new Dictionary<int, string>()
            {
                {1,"Ankara" },
                {2,"İzmir" },
                {3,"Konya" },
                {4,"Samsun" },
                {5,"Denizli" },
                {6,"Eskişehir" },
                {7,"Aydın" }
            };

            if (telephoneCodes.ContainsKey(2)) {

                Console.WriteLine("\aBartın'nın kod bilgisi temsili değildir");
                telephoneCodes.Add(212, "Bartın");
                Console.WriteLine("Yeni Kod Eklendi.");
            }

            if (telephoneCodes.ContainsValue("Edirne"))
            {
                Console.WriteLine("\aEdirne'nın kod bilgisi tanımlı değil!");
                telephoneCodes.Add(8, "Edirne");
                Console.WriteLine("\nYeni kod eklendi");
            }

            foreach (var s in telephoneCodes)
            {
                Console.WriteLine(s);
            }
           





            Console.ReadKey();

        }
    }
}
