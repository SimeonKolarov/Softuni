using System;
using System.Collections.Generic;
using System.Linq;
namespace Advance
{
    class Program
    {
        static void Main(string[] args)
        {

            var myDictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string capital = input[0];
                string country = input[1];
                string tower = input[2];

                if (!myDictionary.ContainsKey(capital))
                {
                    myDictionary.Add(capital, new Dictionary<string, List<string>>());
                }

                if (!myDictionary[capital].ContainsKey(country))
                {
                    myDictionary[capital].Add(country, new List<string>());
                }

                myDictionary[capital][country].Add(tower);
            }


            foreach (var item in myDictionary)
            {
                var continentName = item.Key;
                var countryPrint = item.Value;

                Console.WriteLine($"{continentName}: ");

                foreach (var s in countryPrint)
                {
                    Console.WriteLine($" {s.Key} -> {string.Join(", ", s.Value)}");
                }
            }
        }
    }


}

