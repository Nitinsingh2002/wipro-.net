internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // to write 
        //FileStream fs = new FileStream("xyz.txt", FileMode.OpenOrCreate);
        //StreamWriter sm = new StreamWriter(fs);
        //sm.WriteLine("hello i am first text");
        ////sm.WriteLine("hello i am second text");

        //sm.Close();
        //fs.Close();


        //to read

        //FileStream fs = new FileStream("xyz.txt",FileMode.OpenOrCreate);
        //StreamReader sr = new StreamReader(fs);
        //Console.WriteLine(sr.ReadToEnd());
        //sr.Close();
        //fs.Close();


        File.Delete("abc.txt");


    }
}