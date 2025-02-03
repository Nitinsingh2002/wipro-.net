using System;


internal class Program
{
    public delegate void mydelegate(string str);

    public delegate int mydelgate2(int a, int b);

    private static void Main(string[] args)
    {
        mydelegate md = delegate (string str)
        {
            Console.Write(str);
        };

        md("hello");


        //anonymous delegate 
        mydelgate2 me = delegate (int a, int b)
        {
            return a + b;
        };

       Console.WriteLine(me(2, 2));
    }
}