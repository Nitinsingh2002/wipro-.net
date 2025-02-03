using System.Diagnostics;

internal class Program
{
    // Creating a delegate that takes a string parameter
    public delegate void delsample(string str);

    // Creating another delegate that takes no parameters
    public delegate void delsample2();

    private static void Main(string[] args)
    {
        // Creating an instance of the delegate and passing the target method
        delsample d = new delsample(display);
        d("Welcome to delegates");

        // Creating an instance of delsample2 delegate
        // This binds to an overloaded display method that takes no arguments
        delsample2 d2 = new delsample2(display);

        // Calling the delegate, which invokes the display method without arguments
        d2();
    }

    // Target method that matches the delsample delegate signature
    public static void display(string str)
    {
        Console.WriteLine(str);
    }

    // Overloaded target method that matches the delsample2 delegate signature
    public static void display()
    {
        Console.WriteLine("This is the parameterless display method");
    }
}



//step 1 create a delegate 
//step 2  create instance and pass the target method
//step 3   invoke the delegate