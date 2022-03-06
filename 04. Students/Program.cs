using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _04._Students
{
    class Student
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string[] student = input.Split(' ');
                string firsName = student[0];
                string lastName = student[1];
                int age = int.Parse(student[2]);
                string homeTown = student[3];
                Student newStudent = new Student();
                newStudent.FirtsName = firsName;
                newStudent.LastName = lastName;
                newStudent.Age = age;
                newStudent.HomeTown = homeTown;
                students.Add(newStudent);
            }
            string filter = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == filter)
                {
                        Console.WriteLine($"{student.FirtsName} {student.LastName} is {student.Age} years old.");
                }
            }
            
        }
    }
}
