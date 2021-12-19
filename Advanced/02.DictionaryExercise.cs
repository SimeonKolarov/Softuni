using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace Advanced
{
    class Program
    {


        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> one = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] cloth = input[1].Split(',');

                if (!one.ContainsKey(color))
                {
                    one.Add(color, new Dictionary<string, int>());

                }

                for (int k = 0; k < cloth.Length; k++)
                {
                    string currDress = cloth[k];

                    if (!one[color].ContainsKey(currDress))
                    {
                        one[color].Add(currDress, 0);
                    }

                    one[color][currDress]++;
                }


            }

            string[] searching = Console.ReadLine().Split();

            foreach (var item in one)
            {
                Console.WriteLine($"{item.Key} clothes: ");

                foreach (var i in item.Value)
                {
                    if (item.Key == searching[0] && i.Key == searching[1])
                    {
                        Console.WriteLine($"* {i.Key} - {i.Value} (found!)");
                    }
                    else
                    {

                        Console.WriteLine($"* {i.Key} - {i.Value}");
                    }
                }
            }

        }
    }
}
