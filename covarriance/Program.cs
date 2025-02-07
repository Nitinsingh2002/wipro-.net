using covarriance;

internal class Program
{
    //definfed delegate with return type as vehicle
    public delegate Vehicle mydelegate();
    private static void Main(string[] args)
    {

        Vehicle v = new Vehicle();

        Car c = new Car();


        //create instance of delegate 
        //target function is create of vehicle class so we create object of vehicle to acess that function 

        mydelegate md = new mydelegate(v.create);
        md();
        md = new mydelegate(c.createCar);
        md();
    }
}