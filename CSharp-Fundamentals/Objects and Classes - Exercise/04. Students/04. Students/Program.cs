using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp112
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] curStudentInfo = Console.ReadLine().Split();
                var student = new Student(curStudentInfo[0], curStudentInfo[1], double.Parse(curStudentInfo[2]));
                students.Add(student);
            }
            students = students.OrderByDescending(currStudent => currStudent.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Firstname:f2} {student.Lastname:f2}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public Student(string firstname, string lastname, double grade)
        {
            Firstname = firstname;
            Lastname = lastname;
            Grade = grade;
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Grade { get; set; }

    }
}