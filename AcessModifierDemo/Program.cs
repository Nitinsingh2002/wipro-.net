using WiproDay3Demo;

internal class Program
{
    private static void Main(string[] args)
    {

        //testing of public it work 
        //string name = "nitin";
        //int age = 12;
        //Emp e = new Emp(name,age);
        //e.display();


        //testing of internal
        //since class Product is defined internal so we can use outside wiproDay3Demo beacuse class student defined in that project
        string name = "nitin";
        int age = 13;
        //we cant do this because class Product is declared as internal so product is aceesible with in same assembly or project
        //Product s = new Product(name,age);
        //s.display();
    }
}