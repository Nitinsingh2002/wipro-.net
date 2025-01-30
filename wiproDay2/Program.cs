using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter first string value");
        string? a = Console.ReadLine();


        Console.WriteLine("Enter second string value");
        string ? b = Console.ReadLine();

        Console.WriteLine(a + b);


        StringBuilder sbss = new StringBuilder();
        Console.WriteLine("enter first value");
        string ?ab = Console.ReadLine();

        Console.WriteLine("enter second value");
        string? abc = Console.ReadLine();
        sbss.Append(ab);
        sbss.Append(abc);
        Console.WriteLine(sbss);




    }
}