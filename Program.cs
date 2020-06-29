using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();

            persons.Add(new Human("Janis", "Simanson", 50, "Green"));
            persons.Add(new Human("Robert", "Simanson", 13, "Grey"));
            persons.Add(new Human("Natalja", "Simansone", 48, "Blue"));
            persons.Add(new Human("Michael", "Jonhson", 20, "Red"));

            //persons[2].SetAge(15);

            foreach(var person in persons)
            {
                person.Introduce();
            }

            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BankAccount("Robert", 200, "132456", DateTime.Now, "EUR"));
            accounts[0].PrintInfo();

            accounts.Add(new BankAccount("Janis", 10000, "123456", DateTime.Now, "EUR"));
            accounts[1].PrintInfo();

            accounts.Add(new BankAccount("Natalja", 7000, "167456", DateTime.Now, "EUR"));
            accounts[2].PrintInfo();

            //accounts[0].Owner = "Robert";
            //accounts[0].AccountNumber = "135616235127";
            //accounts[0].Created = DateTime.Now;
            //accounts[0].Balance = 784;
            //accounts[0].Currency = "EUR";
            //accounts[0].Balance = 200000000;
            //accounts[0].PrintInfo();
        }
    }
}
