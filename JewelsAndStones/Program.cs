using System;

namespace JewelsAndStones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jewels = Console.ReadLine();
            string stones = Console.ReadLine();
            int sayac = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                for (int j = 0; j < jewels.Length; j++)
                {
                    if (stones[i] == jewels[j])
                    {
                        sayac++;
                    }
                }
            }

            Console.WriteLine(sayac);
        }
    }
}
