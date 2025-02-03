internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;

            }
            catch (Exception e)
            {
                FileStream fs = new FileStream("abc.txt", FileMode.OpenOrCreate);
                StreamWriter sm = new StreamWriter(fs);
                sm.WriteLine(e.Message);
                sm.WriteLine(e.StackTrace);
                sm.WriteLine(e.Source);
                sm.WriteLine(e.GetType());
                sm.WriteLine(e.GetType().Name);

                sm.Close();
                fs.Close();
                throw new Exception("error in dividing",e);

            }
        }
        catch (Exception e) { 
            Console.WriteLine(e.Message);
           
            if(e.InnerException != null)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }
    }
}