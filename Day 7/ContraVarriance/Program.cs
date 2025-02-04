using ContraVarriance;

internal class Program
{
    public delegate void mydelegte(Car c);
    private static void Main(string[] args)
    {
        Vehicle v = new Vehicle();
        Car c = new Car();

        //creating instance of delegate 
        mydelegte md = new mydelegte(v.display);
        md(c);

    }
}