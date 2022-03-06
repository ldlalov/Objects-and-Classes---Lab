
using System;
using System.Collections.Generic;

namespace _05._Students_2._0
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
            while ((input = Console.ReadLine()) != "end")
            {
                string[] student = input.Split(' ');
                string firsName = student[0];
                string lastName = student[1];
                int age = int.Parse(student[2]);
                string homeTown = student[3];
                if (!IsStudentExisting(students, firsName, lastName))
                {
                    Student newStudent = new Student();
                    newStudent.FirtsName = firsName;
                    newStudent.LastName = lastName;
                    newStudent.Age = age;
                    newStudent.HomeTown = homeTown;
                    students.Add(newStudent);
                }
                else
                {

                    UpdateStudent(students,firsName,lastName,age, homeTown);
                }
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

        private static void UpdateStudent(List<Student> students,string firstName, string lastName, int age, string homeTown)
        {
            foreach (Student student in students)
            {
                if (student.FirtsName == firstName && student.LastName == lastName)
                {
                    student.FirtsName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                }
            }
        }

        static bool IsStudentExisting(List<Student> students, string firsName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirtsName == firsName && student.LastName == lastName)
                {
                    return true;
                }
            }
                    return false;
        }
    }
}
