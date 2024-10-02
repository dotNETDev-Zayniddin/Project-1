using System;
namespace Project
{
    class Program 
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Your name:");
            string name = Console.ReadLine();
            string greeding  = $"Hello, {name}";
            System.Console.WriteLine(greeding);
            System.Console.WriteLine("Enter your age");
            string ageAsString = Console.ReadLine();
            System.Console.WriteLine("Converting...");
            int age = ConverzWriteLine($"Succesfully converted! {age}");
            int keschasAge = 3;
            int ageDifference = age - keschasAge;
            System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");
            System.Console.WriteLine($"You are older than Keshcha: {ageDifference > 0}");
            System.Console.WriteLine($"You are older or equal to Keshcha: {ageDifference >= 0}");
            System.Console.WriteLine($"You are younger or equal to Keshcha: {ageDifference <= 0}");
            System.Console.WriteLine($"You are not equal to Keshcha: {ageDifference != 0}");
        }
    }
}
