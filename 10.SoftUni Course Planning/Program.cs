using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(":").ToArray();
                string currentCommand = command[0];
                

                //•	Add:{lessonTitle} – add the lesson to the end of the schedule, if it does not exist
                if (currentCommand == "Add")
                {
                    bool contains = lessons.Contains(command[1]);
                    if (!contains)
                    {
                        lessons.Add(command[1]);
                    }

                }
                else if (currentCommand == "Insert")
                {
                    bool contains = lessons.Contains(command[1]);
                    if (!contains)
                    {
                        int insertIndex = int.Parse(command[2]);
                        lessons.Insert(insertIndex, command[1]);
                    }
                }
                else if (currentCommand == "Remove")
                {
                    bool contains = false;
                    int indexThatContains = 0;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == command[1])
                        {
                            contains = true;
                            indexThatContains = i;
                            break;
                        }
                    }
                    if (contains)
                    {
                        lessons.RemoveAt(indexThatContains);
                    }
                }
                else if (currentCommand == "Swap")
                {
                    bool firstLessonContains = false;
                    bool secondLessonContains = false;
                    int indexOfFirstLesson = 0;
                    int indexOfsecondLesson = 0;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        // array ... metod
                        if (lessons[i] == command[1])
                        {
                            //array
                            firstLessonContains = true;
                            indexOfFirstLesson = i;
                            continue;
                        }
                        if (lessons[i] == command[2])
                        {
                            //metod
                            secondLessonContains = true;
                            indexOfsecondLesson = i;
                        }
                    }
                    if (firstLessonContains && secondLessonContains)
                    {
                        //int index1 = list.IndexOf("B");
                        //int index2 = list.IndexOf("D");
                        //list.Insert(index1, list[index2]);
                        //list.RemoveAt(index2 + 1);

                        //list.Insert(index2, list[index1 + 1]);
                        //list.RemoveAt(index1 + 1);
                        lessons.Insert(indexOfFirstLesson, lessons[indexOfsecondLesson]);
                        lessons.RemoveAt(indexOfsecondLesson + 1);
                        lessons.Insert(indexOfsecondLesson + 1, lessons[indexOfFirstLesson + 1]);
                        lessons.RemoveAt(indexOfFirstLesson + 1);
                    }
                }
                else if (command[0] == "Exercise")
                {
                    bool isLessonExist = false;
                    bool isThereExerciseAlready = false;
                    int indexOfExercise = 0;
                    int indexOfLesson = 0;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (command[1] == lessons[i])
                        {
                            isLessonExist = true;
                            
                            indexOfLesson = i;
                        }

                    }
                    if (!isThereExerciseAlready)
                    {
                        isThereExerciseAlready = true;
                        if (!isLessonExist)
                        {
                            lessons.Add(command[1]);
                            lessons.Add($"{command[1]}-Exercise");
                            List<string> sublist = lessons.GetRange(lessons.Count - 2, lessons.Count - 1);

                        }
                        else if (isLessonExist)
                        {
                            string Exercise = command[0];
                            string add = command[1] + Exercise;
                            lessons.Insert(indexOfLesson+1,add);
                            List<string> sublist = lessons.GetRange(indexOfLesson + 1,2);


                        }

                    }

                }


            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }
        }
    }
}
