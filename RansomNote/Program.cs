using System;
using System.Collections.Generic;

namespace RansomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ransomNote = Console.ReadLine();
            string magazine = Console.ReadLine();

            //Dictionary<Key_Tipi, Value_Tipi> Referans_Adi = new Dictionary<Key_Tipi, Value_Tipi>();
            var dict = new Dictionary<char, int>();

            foreach (var c in magazine)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach (var c in ransomNote)
            {
                if (!dict.ContainsKey(c) || dict[c] <= 0 )
                {
                    Console.WriteLine("false");
                }
                dict[c]--;
            }

            Console.WriteLine(true);

        }
    }
}
