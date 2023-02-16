using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command ="";

            while ((command = Console.ReadLine()) != "end")
            {

                string[] input = command.Split().ToArray();

                if (input.Length == 2)
                {
                    int newWagon = int.Parse(input[1]);
                    wagons.Add(newWagon);
                }
                else if (input.Length == 1)
                {
                    int newPassengers = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= maxCapacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }

                }

            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
