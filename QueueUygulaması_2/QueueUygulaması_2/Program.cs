using System;
using System.Collections.Generic;

namespace QueueUygulaması_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sesli harfler listesi
            var vowels = new List<char> { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            var vowelQueue = new Queue<char>();

            // Kullanıcıdan cümle girişi alıyoruz
            Console.WriteLine("Bir cümle giriniz:");
            string sentence = Console.ReadLine().ToLower();

            // Her karakteri kontrol edip sesli harfleri kuyruğa ekliyoruz
            foreach (char ch in sentence)
            {
                if (vowels.Contains(ch))
                {
                    vowelQueue.Enqueue(ch);
                }
            }

            // Sesli harf sayısını bulup ekrana yazdırıyoruz
            var vowelCounts = new Dictionary<char, int>();
            while (vowelQueue.Count > 0)
            {
                char vowel = vowelQueue.Dequeue();
                if (vowelCounts.ContainsKey(vowel))
                {
                    vowelCounts[vowel]++;
                }
                else
                {
                    vowelCounts[vowel] = 1;
                }
            }

            Console.WriteLine("Sesli harflerin sayısı:");
            foreach (var kvp in vowelCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // Programın sonlanmaması için kullanıcıdan bir tuşa basmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
