using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassroomProject
{
   public class StartUp
    {
        static void Main(string[] args)
        {
          Predicate<int> isEven = number => number % 2 == 0;
            List<int> numbers = new List<int>();

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            string evenOdd = Console.ReadLine();

          if (evenOdd == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => isEven(x))));
            }

          else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => !isEven(x))));
            }

        }

        }
    }   
