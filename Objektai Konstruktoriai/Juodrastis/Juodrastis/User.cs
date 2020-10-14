using System;
using System.Collections.Generic;
using System.Text;

namespace Juodrastis
{
    public class User
    {

        public User(string name)
        {
            Name = name;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
