using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CustomClassesLibrary.Homework14
{
    public class Person
    {
        [PersonValidation(@"^(?:1[8-9]|[2-9][0-9]|1[01][0-9])$", ErrorMessage = "U must be older 18")]
        public int Age { get; set;}
        [PersonValidation(@"^([A-Z]{1}[A-Za-z]{1,40})$", ErrorMessage = "First name should begin with Uppercase char and not longer than 40 chars")]
        public string FirstName { get; set; }
        [PersonValidation(@"^([A-Z]{1}[A-Za-z]{1,40})$", ErrorMessage = "Last name should begin with Uppercase char and not longer than 40 chars")]
        public string LastName { get; set; }

        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public bool IsValid()
        {
            Type item = this.GetType();

            PropertyInfo[] properties = item.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (PropertyInfo property in properties)
            {
                foreach (var attr in property.GetCustomAttributes(false))
                {
                    var temp = attr as PersonValidationAttribute;
                    if (temp != null && !temp.IsValid(property.GetValue(this)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
