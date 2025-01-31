using wiproo_day_5__exception_handling_;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("enter a number");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("enter number b");
        //int b =  Convert.ToInt32(Console.ReadLine());

        //try
        //{
        //    int c = a / b;
        //    Console.WriteLine(c);
        //}
        //catch(DivideByZeroException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}


        //throwing custom exception 


        Console.WriteLine("Enter your age");

        int a = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (a < 18)
            {
                throw new AgeException("invalid age");
            }
        }
        catch(AgeException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }
}