using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }

        public Human()
        {

        }

        public void Introduce()
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("My full name is " + this.Name + " " + this.Surname + ".");
            Console.WriteLine("I am " + this.Age + " years old.");
        }
    }
}
