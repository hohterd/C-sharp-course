using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomClassesLibrary.Homework17
{
    public static class LinqTasks
    {

        public static string StringEndWithLastChar(string str, char symbol)
        {
            var temp = str.Split().Where(x => x.EndsWith(symbol));

            if (temp.Count() > 1)
            {
                throw new ArgumentOutOfRangeException($"count of strings end with {symbol} > 1");
            }

            return temp.FirstOrDefault();
        }

        public static double AverageSumOfElementsMoreThanZero(int[] array)
        {
            var temp = array.Where(x => x > 0).Average();

            return temp;
        }

        public static void ReplaceOCharsInString(int[] array)
        {
            string input = "Женя скоро будет свободен, а у вас всё только начинается";

            string output = new string(input.Select(x => x == 'о' ? ' ' : x).ToArray());

            Console.WriteLine(output);
        }

        public static void UsingJoinWhileTakeSkipSelect(List<Course> courseList, List<Student> studentList)
        {
            var allStudent = courseList.GroupJoin(studentList,
                course => course.CourseID,
                student => student.CourseID,
                (courses, students) => new
                {
                    NameCourse = courses.CourseName,
                    Students = students
                });

            foreach (var course in allStudent.Skip(1))
            {
                Console.WriteLine(course.NameCourse);
                foreach (var student in course.Students.Take(3).Where(x => x.Grade > 7))
                {
                    Console.WriteLine($"{student.StudentName} - ({student.Grade})");
                }
                Console.WriteLine();
            }
        }

        /*var studentList = new List<Student>()
            {
                new Student()
                {
                    StudentID = 1,
                    StudentName = "Sergey",
                    CourseID = 1,
                    Grade = 5,
                },

                new Student()
                {
                    StudentID = 2,
                    StudentName = "Dmitriy",
                    CourseID = 1,
                    Grade = 8,
                },

                new Student()
                {
                    StudentID = 2,
                    StudentName = "Andrey",
                    CourseID = 2,
                    Grade = 9,
                },

                new Student()
                {
                    StudentID = 3,
                    StudentName = "Alexey",
                    CourseID = 2,
                    Grade = 8,
                },
                new Student()
                {
                    StudentID = 4,
                    StudentName = "Alexander",
                    CourseID = 3,
                    Grade = 6,
                },

                new Student()
                {
                    StudentID = 4,
                    StudentName = "Vladimir",
                    CourseID = 3,
                    Grade = 9,
                },
                new Student()
                {
                    StudentID = 5,
                    StudentName = "Nikita",
                    CourseID = 2,
                    Grade = 2,
                }
            };

        var courseList = new List<Course>()
            {
                new Course()
                {
                    CourseID = 1,
                    CourseName = "C#",
                },

                new Course()
                {
                    CourseID = 2,
                    CourseName = "Java",
                },
                new Course()
                {
                    CourseID = 3,
                    CourseName = "Python"
                }
            };*/
    }
}
