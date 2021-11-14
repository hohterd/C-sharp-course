using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Homework9
{
    public class Car : IDrive
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Car(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Start()
        {
            Console.WriteLine("Car start");
        }
    }
}
