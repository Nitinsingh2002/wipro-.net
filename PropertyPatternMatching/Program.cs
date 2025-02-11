// See https://aka.ms/new-console-template for more information
using PropertyPatternMatching;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Person p = new Person { Name = "John", Age = 25 };

        string ans = p switch 
        {
            { Age: < 13 } => "Child",
            { Age: var age } when age >= 13 && age < 18 => "Teenager",
            { Age: >= 18 } => "Adult",
            _ => "Unknown"
        };
    }



  
}