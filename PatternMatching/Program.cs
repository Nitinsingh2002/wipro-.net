using PatternMatching;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter value of a");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ENter value of b");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose option between 1 to 4");
        Console.WriteLine("1 for addition , 2 for substraction , 3 for multiply, 4 for division");
        int value = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(ans(value, a, b));

        MathOp m = new MathOp();
        int result  = value switch
        {
            1 => m.add(a, b),
            2 => m.substract(a, b),
            3 => m.multiply(a, b),
            4 => m.divide(a, b),
            _ => 0
        };

        Console.WriteLine(result);
        
    }


   public static int ans (int value, int a, int b)
    {
        MathOp m = new MathOp();
        return value switch
        {
            1 => m.add(a, b),
            2 => m.substract(a, b),
            3 => m.multiply(a, b),
            4 => m.divide(a, b),
            _ => 0

        };

    }


    //with  traditional switch statement
    public static string getDay(int day)
    {
        switch (day)
        {
            case 1:
            case 7:
                return "Weekend";
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                return "weekdays";
            default:
                return "Invalid day";
        };
    }

    //same function with switch expression 
    public static string getDayType(int day)
    {
       return  day switch
        {
            1 or 7 => "Weekend",
            2 or 3 or 4 or 5 or 6 => "Weekdays",
            _ => "invalid date"
        };
    }


}