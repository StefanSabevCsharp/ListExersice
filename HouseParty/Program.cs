using System;
using System.Collections.Generic;
using System.Linq;
namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int numberOfCommands = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string name = command[0];
                bool contains = names.Contains(name);

                if (command.Length == 3)
                {
                    if (contains)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);

                    }

                }
                else if (command.Length == 4)
                {
                    if (contains)
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
