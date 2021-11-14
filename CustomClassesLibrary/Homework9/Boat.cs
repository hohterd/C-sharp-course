using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Homework9
{
    public class Boat : IDrive
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Boat(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Start()
        {
            Console.WriteLine("Boat Start");
        }
    }
}
