using ReflectionDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(typeof(Demo).FullName);

        Type type = typeof(Demo);

        Console.WriteLine("field are");
        foreach(var t in type.GetProperties())
        {
            Console.WriteLine(t.Name);
        }
        Console.WriteLine("methods are");

        foreach (var method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}