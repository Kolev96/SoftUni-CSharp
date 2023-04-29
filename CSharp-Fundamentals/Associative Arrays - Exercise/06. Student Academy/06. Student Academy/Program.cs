using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double studentAvgGrade = student.Value.Average();

                if (studentAvgGrade >= 4.5)
                {
                    Console.WriteLine($"{studentName} -> {studentAvgGrade:f2}");
                }
            }
        }
    }
}