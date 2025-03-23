using System;
using ConsoleApp1;
using MyApplication;
class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "John";
        p1.Age = 25;
        p1.Introduce();

        Car c1 = new Car();
        c1.Model = "Tesla";
        c1.Year = 2023;
        c1.ShowDetails();

        Datatypes d1 = new Datatypes();

        OperatorsInCS op1 = new OperatorsInCS();

        BankAccount b1 = new BankAccount();
        b1.Deposit(500);
        b1.Withdraw(200);
        Console.WriteLine($"Current Balance: {b1.GetBalance()}");
    }
}