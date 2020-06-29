using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Human
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; private set; }
        public string EyeColor { get; }

        public Human(string name, string surname, int age, string eyeColor)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.EyeColor = eyeColor;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("My full name is " + this.Name + " " + this.Surname + ".");
            Console.WriteLine("I am " + this.Age + " years old.");
        }

        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void SayName()
        {
            Console.WriteLine(this.Name);
        }

        public void SetAge(int age)
        {
            if(age < 0)
            {
                return;
            }
            else if(age < this.Age)
            {
                Console.WriteLine("Hacker spotted!!");
                return;
            }
            else
            {
                this.Age = age;
            }
        }
    }
}
