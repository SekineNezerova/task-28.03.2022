using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSingerClass
{
    class Singer
    {
        private string _name; 
        private string _surname;
        private int _age;

        public string Name {
            get 
            {
                return _name;

            }
            set
             {
                if (value.Length<=100)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name valid deyil");
                }
            }
        }
        public string SurName
        {
            get
            {
                return _surname;
            }

            set
            {
                if (value.Length<=100)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Surname valid deyil");
                }
            }
        }
        public int Age{ 
            get
            {
                return _age;

            }
            set
            {
                if (value>0&&value<=170)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age valid deyil");
                }
            }
        }
    }
}
