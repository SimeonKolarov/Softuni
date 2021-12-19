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
            Dictionary<string, string> password = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                string[] arg = command.Split(":");

                if (!password.ContainsKey(arg[0]))
                {
                    password.Add(arg[0], arg[1]);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            //C# Fundamentals=>fundPass=>Tanya=>350

            while (command != "end of submissions")
            {
                string[] arg = command.Split("=>");
                string contest = arg[0];
                string pass = arg[1];
                string ussername = arg[2];
                int points = int.Parse(arg[3]);

                if (password.ContainsKey(contest) && password[contest].Contains(pass))
                {
                    if (!result.ContainsKey(ussername))
                    {
                        result.Add(ussername, new Dictionary<string, int>());
                        result[ussername].Add(contest, new int { });
                        result[ussername][contest] = points;
                    }

                    else
                    {

                        if (!result[ussername].ContainsKey(contest))
                        {
                            result[ussername].Add(contest, new int { });
                            result[ussername][contest] = points;

                        }

                        else
                        {
                            if (result[ussername][contest] < points)
                            {
                                result[ussername][contest] = points;
                            }
                        }

                    }
                }


                command = Console.ReadLine();
            }


            int topSum = 0;
            string name = " ";

            foreach (var item in result)
            {

                int sum = 0;

                foreach (var i in item.Value)
                {

                    sum += i.Value;

                }

                if (sum > topSum)
                {
                    name = item.Key;
                    topSum = sum;
                }
            }


            Console.WriteLine($"Best candidate is {name} with total {topSum} points.");
            Console.WriteLine($"Ranking:");


            foreach (var item in result.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var i in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {i.Key} -> {i.Value}");
                }
            }
        }

    }
}

