using System;

namespace Juodrastis
{
     public class Program
    {
        static void Main(string[] args)
        {
            

            User vartotojas = new User("Edgaras") { Password = "labas", Username = "test" };
            User vartotojas1 = new User("Edgaras1") { Password = "labas1", Username = "test1" };
            User vartotojas2 = new User("Edgaras") { Password = "labas2", Username = "test2" };
            User vartotojas3 = new User("Edgaras") { Password = "labas3", Username = "test3" };
            User vartotojas4 = new User("Edgaras") { Password = "labas4", Username = "test4" };
            User[] useriai = new User[]
            {
                vartotojas, vartotojas1, vartotojas2, vartotojas3, vartotojas4
            };

            Console.WriteLine("Iveskite username");
            string usernameinput = Console.ReadLine();
            Console.WriteLine("Iveskite slaptazodi");
            string passwordinput = Console.ReadLine();
            bool matchfound = false;
            foreach (var user in useriai)
            {
                
                if (usernameinput == user.Username && passwordinput == user.Password)
                {
                    matchfound = true;
                    Console.WriteLine("Hello " + user.Name);
                }
    
            }
            if (!matchfound)
            {
                Console.WriteLine("Blogai ivestas slaptazodis");
            }
        }
    }
}
