using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppClass
{
    class User:Post
    {

        public string name;
        public string surname;
        public string email;
        public string DateOfBirth;
        public string isSingle;
        public string[] Post;

       
        public User()
        {
            Console.WriteLine("user created");
        }
        public User(string Name, string Surname) : this()
        {
            this.name = Name;
            this.surname = Surname;
            Console.WriteLine("added name and surname");
        }
        public User(string Name, string Surname,string dateofbirth, string email, string issingle):this(Name,Surname)
        {
            Console.WriteLine("added all information");
            this.DateOfBirth = dateofbirth;
            this.email = email;
            this.isSingle = issingle;

         }
        
    } 
}

