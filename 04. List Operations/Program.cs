using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split().ToArray();
                string action = input[0];
                switch (action)
                {
                    case "Add":
                        int number = int.Parse(input[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        int insertNum = int.Parse(input[1]);
                        int insertIndex = int.Parse(input[2]);
                        if (insertIndex >= 0 && insertIndex < numbers.Count)
                        {
                        numbers.Insert(insertIndex, insertNum);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(input[1]);
                        if (removeIndex >= 0 && removeIndex < numbers.Count)
                        {
                            numbers.RemoveAt(removeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int countOfShifts = int.Parse(input[2]);

                        if (input[1] == "left")
                        {
                            for (int i = 0; i < countOfShifts; i++)
                            {
                                int firstNum = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(firstNum);

                            }

                        }
                        else if (input[1] == "right")
                        {
                            for (int i = 0; i < countOfShifts; i++)
                            {
                                int lastNum = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, lastNum);
                            }

                        }

                        break;


                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
