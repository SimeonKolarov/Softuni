using System;
using System.Collections.Generic;
using System.Linq;
namespace Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> one = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    one.Push(command[1]);
                }

                else if (command[0] == 2 && one.Count > 0)
                {
                    one.Pop();
                }

                else if (command[0] == 3)
                {
                    if (one.Count > 0)
                    {

                        int max = one.Max();
                        Console.WriteLine(max);
                    }
                }

                else if (command[0] == 4)
                {
                    if (one.Count > 0)
                    {
                        int min = one.Min();
                        Console.WriteLine(min);

                    }
                }

            }

            Console.WriteLine(string.Join(", ", one));

        }
    }
}
