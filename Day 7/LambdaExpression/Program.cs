internal class Program
{
    private static void Main(string[] args)
    {
        Func<int, int> square = a => a * a;
        Console.WriteLine(square(2));



        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(2, 3));



        Func<int, int, int> multi = (a, b) =>
        {
            Console.WriteLine(a * b);
            return a * b;
        };
    }
}