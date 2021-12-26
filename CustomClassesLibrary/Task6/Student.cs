using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Task6
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string CourseName { get; set; }
        public static Repository<Student> StudentRepository { get; set; } = new Repository<Student>();

        public Student(string name, int grade, string coursename)
        {
            Name = name;

            Grade = grade;

            CourseName = coursename;
        }
       
    }
}
