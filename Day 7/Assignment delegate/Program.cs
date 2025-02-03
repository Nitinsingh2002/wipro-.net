using System;
using System.Data;


public  delegate int mydelegate(int a, int b);
internal class Program
{


    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }


    public static int Divide(int a, int b)
    {
        return a / b;
    }
    // Implement callback mechanism
    // Complete Step 3:............

    public static int PerformOperation(int a, int b, string operation)
    {
        if (operation.Equals("add"))
        {
            mydelegate md = new mydelegate(Add);
            int result = md(a, b);
            return result;
        }
        else if (operation.Equals("subtract"))
        {
            mydelegate md = new mydelegate(Subtract);
            int result = md(a, b);
            return result;
        }
        else if (operation.Equals("multiply"))
        {
            mydelegate md = new mydelegate(Multiply);
            int result = md(a, b);
            return result;
        }
        else  
        {
            mydelegate md = new mydelegate(Divide);
            int result = md(a, b);
            return result;
        }
    }

    static void Main(string[] args)
    {

        // Input handling
        // Complete Step 4:............
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
        string str = Console.ReadLine();

        if (str.Equals("add"))
        {
            int result = PerformOperation(a, b, "add");
            Console.WriteLine($"Result:{result}");

        }
        else if (str.Equals("subtract"))
        {
            int result = PerformOperation(a, b, "subtract");
            Console.WriteLine($"Result:{result}");

        }
        else if (str.Equals("multiply"))
        {
            int result = PerformOperation(a, b, "multiply");
            Console.WriteLine($"Result:{result}");
            throw new InvalidOperationException("Invalid operation")
        }
        else if (str.Equals("divide"))
        {
            int result = PerformOperation(a, b, "divide");
            Console.WriteLine($"Result:{result}");
        }


        // Output handling
        // Complete Step 5:............
    }
}
