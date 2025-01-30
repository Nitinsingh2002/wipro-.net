internal class Program
{
    //pass by value method
    public static void abc(int value)
    {
        value = value * 10;
        Console.WriteLine(value);
    }



    //pass by ref method
    public static void ac(ref int a)
    {
        a = a * 10;
        Console.WriteLine("inside the method" + a);
    }


    //pass by out 
    public static int calculate(int a, int b,out int reminder)
    {

        reminder = a % b;
        int quoitent = a / b;
        a = 100;
        return quoitent;

    }
    private static void Main(string[] args)
    {
        // pass by value 
        //int a = 10;
        //Console.WriteLine("before calling method" + a);
        //abc(a);
        //Console.WriteLine("after calling method" + a);



        //pass by refrance 
        //int a = 10;
        //Console.WriteLine("before calling method" + a);
        //ac(ref a);
        //Console.WriteLine("after calling method" + a);

        //pass by out
        int a = 10;
        int b = 5;
        int reminder;
        Console.WriteLine("befor calling method value is" + a);
       int qut = calculate(a, b, out reminder);
        Console.WriteLine(qut);
        Console.WriteLine(reminder);
        Console.WriteLine("befor calling method value is" + a);

    }
}