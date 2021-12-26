using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomClassesLibrary.Task6
{
    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public static Repository<User> StudentRepository { get; set; } = new Repository<User>();

        // Constructor with all fields
        public User(int age, string name, string nickname)
        {
            Age = age;
            Name = name;
            NickName = nickname;
        }

        // Empty constructor
        public User()
        {

        }

        
    }
}
