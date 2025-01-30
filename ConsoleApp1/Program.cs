using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "wipro training";
            //Console.WriteLine("welcome to" + name);


            ////boxing
            //int a = 10;
            //Object obj = a;
            //Console.WriteLine(obj);


            ////unboxing 
            //int result = (int)obj;
            //Console.WriteLine(result);

            Console.WriteLine("Enter your name");
            String ? name = Console.ReadLine();
            Console.WriteLine($"you name is {name}");
        }
    }
}