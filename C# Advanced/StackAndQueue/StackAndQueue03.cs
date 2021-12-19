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

            var ingredients = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            var freshness = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int dippingSauce = 0;
            int greenSalads = 0;
            int chockolateCake = 0;
            int lobster = 0;

            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                var ingredient = ingredients.Peek();
                var fresh = freshness.Peek();
                var freshenessLevel = ingredient * fresh;

                if (freshenessLevel == 150)
                {
                    dippingSauce++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }

                else if (freshenessLevel == 250)
                {
                    greenSalads++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }

                else if (freshenessLevel == 300)
                {
                    chockolateCake++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }

                else if (freshenessLevel == 400)
                {
                    lobster++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }

                else if (ingredient == 0)
                {
                    ingredients.Dequeue();
                }

                else
                {
                    freshness.Pop();
                    ingredient += 5;
                    ingredients.Dequeue();
                    ingredients.Enqueue(ingredient);
                }
            }

            if (dippingSauce > 0 && greenSalads > 0 && chockolateCake > 0 && lobster > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");

                Console.WriteLine($"# Chocolate cake --> {chockolateCake}");
                Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                Console.WriteLine($"# Green salad --> {greenSalads}");
                Console.WriteLine($"# Lobster --> {lobster}");
            }

            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");

                if (ingredients.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }

                if (dippingSauce > 0)
                {
                    Console.WriteLine($"# Dipping sauce --> {dippingSauce}");

                }

                if (greenSalads > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalads}");

                }

                if (chockolateCake > 0)
                {
                    Console.WriteLine($"# Chocolate cake --> {chockolateCake}");
                }

                if (lobster > 0)
                {
                    Console.WriteLine($"# Lobster --> {lobster}");
                }
            }


        }
    }
}
