using System;
using System.Collections.Generic;
using System.Linq;
namespace Advance
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ");
            Queue<string> collection = new Queue<string>(input);


            while (collection.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    collection.Dequeue();
                }


                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", collection));
                }

                else
                {
                    int index = command.IndexOf(' ');
                    string song = command.Substring(index + 1);

                    if (collection.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }

                    else
                    {
                        collection.Enqueue(song);
                    }
                }


            }

            Console.WriteLine("No more songs!");
        }
    }
}