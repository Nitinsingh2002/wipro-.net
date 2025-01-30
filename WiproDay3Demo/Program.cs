namespace WiproDay3Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // public acess modifier example 
            //string name = "nitin";
            //int age = 12;

            ////Creating object 
            //Emp em = new Emp(name,age);
            //em.display();


            //private acess modifier example 
            string name = "akash";
            int age = 12;
            Student s = new Student(name,age);

            s.display();
        }
    }
}