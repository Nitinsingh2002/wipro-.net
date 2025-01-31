

using Newtonsoft.Json;
using Serlization_And_Deserlization;

internal class Program
{
    private static void Main(string[] args)
    {
        //serlization

        //Employee em = new Employee(1, "nitin");

        ////now we object we to convert ir in byte stream and store in file 
        //FileStream fs = new FileStream("xyz.txt", FileMode.Append);
        //StreamWriter sw = new StreamWriter(fs);

        ////string data = JsonConvert.SerializeObject(em);
        //string data = JsonConvert.SerializeObject(em);
        //Console.WriteLine(data);

        //sw.WriteLine(data);



        //sw.Close();
        //fs.Close();


        //deserlization 
        FileStream fs = new FileStream("xyz.txt", FileMode.OpenOrCreate);
        StreamReader sr = new StreamReader(fs);
        string data = sr.ReadToEnd();
        Employee em = JsonConvert.DeserializeObject<Employee>(data);
        Console.WriteLine($"ID: {em.age}, Name: {em.name}");




    }
}