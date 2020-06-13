using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            Console.WriteLine("Enter your name:");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            person.Surname = Console.ReadLine();
            person.Age = 25;
            person.EyeColor = "Grey";

            person.Introduce();

            //Console.WriteLine(person.Name + " " + person.Surname);

            //person.Name = "Janis";

            //Console.WriteLine(person.Name + " " + person.Surname);
        }
    }
}
