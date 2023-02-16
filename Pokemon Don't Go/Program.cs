using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int indexToRemove = int.Parse(Console.ReadLine());
            int sum = 0;
            while (numbers.Count != 0)
            {
                int valueNumberOfIndex = 0;
                
                if (indexToRemove < 0)
                {
                valueNumberOfIndex = numbers[numbers.Count-1];
                sum += valueNumberOfIndex;
                    numbers.RemoveAt(0);
                    numbers.Insert(0,valueNumberOfIndex);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= valueNumberOfIndex)
                        {
                            numbers[i] += valueNumberOfIndex;

                        }
                        else if (numbers[i] >= valueNumberOfIndex)
                        {
                            numbers[i] -= valueNumberOfIndex;
                        }
                    }
                    if (numbers.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        indexToRemove = int.Parse(Console.ReadLine());

                    continue;
                    }
                }

               // If the given index is greater than the last index of the sequence,
               // remove the last element from the sequence,
               // and copy the first element to its place.
                if (indexToRemove >= numbers.Count)
                {
                    valueNumberOfIndex = numbers[numbers.Count - 1];
                    sum += valueNumberOfIndex;
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(valueNumberOfIndex);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= valueNumberOfIndex)
                        {
                            numbers[i] += valueNumberOfIndex;

                        }
                        else if (numbers[i] >= valueNumberOfIndex)
                        {
                            numbers[i] -= valueNumberOfIndex;
                        }
                    }
                    if (numbers.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        indexToRemove = int.Parse(Console.ReadLine());

                    continue;
                    }
                }
                valueNumberOfIndex = numbers[indexToRemove];
                sum += valueNumberOfIndex;
                numbers.RemoveAt(indexToRemove);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= valueNumberOfIndex)
                    {
                        numbers[i] += valueNumberOfIndex;

                    }
                    else if (numbers[i] >= valueNumberOfIndex)
                    {
                        numbers[i] -= valueNumberOfIndex;
                    }
                }
                if (numbers.Count == 0)
                {
                    break;
                }
                else
                {
                indexToRemove = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine(sum);
        }

    }
}
