using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int num = Convert.ToInt32(Console.ReadLine());

            var numStack = new Stack<int>();
          
            while (num > 0)
            {

                int k = num % 10;
                numStack.Push(k);
                num = num / 10;


            }

            int i = 0;
            int n = numStack.Count - 1;


            foreach (int s in numStack)
            {
                Console.WriteLine($"{s}  x {Math.Pow(10, n - i)} = {s * Math.Pow(10, n - i)}");
                i++;

            }

            Console.ReadKey();

        }
    }
}
