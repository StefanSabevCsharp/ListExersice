using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split().ToArray();
                int element = int.Parse(input[1]);

                if (input.Length == 2)
                {

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.RemoveAll(x => x == numbers[i]);
                        }
                    }

                }
                else if (input.Length == 3)
                {
                    int index = int.Parse(input[2]);
                    numbers.Insert(index, element);

                }



            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
