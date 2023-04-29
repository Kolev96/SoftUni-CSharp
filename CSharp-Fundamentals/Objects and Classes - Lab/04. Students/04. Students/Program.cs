using System;
using System.Collections.Generic;

namespace ConsoleApp104
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] studentsProbs = command.Split(' ');

                Student student = new Student
                {
                    FirstName = studentsProbs[0],
                    LastName = studentsProbs[1],
                    Age = int.Parse(studentsProbs[2]),
                    HomeTown = studentsProbs[3]
                };
                students.Add(student);

            }
            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}