using System;
using System.Collections.Generic;
using System.Linq;

namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> nums = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var num in nums)
            {

                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            foreach (var d in dict.Keys)
            {
                if (dict[d] > n / 2)
                {
                    Console.WriteLine(d);
                }
            }

        }
    }
}
