using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Key              //Values
            // Courses Names -> List<StudentNames>

            var courseInfo = new Dictionary<string, List<string>>();

            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                string[] tokens = cmd.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }
                courseInfo[courseName].Add(studentName);

                cmd = Console.ReadLine();
            }

            PrintCoursesInfo(courseInfo);
        }
        private static void PrintCoursesInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                var students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }

            }
        }
    }
}