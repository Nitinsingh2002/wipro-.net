internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter rows");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter columns");
        int col = Convert.ToInt32(Console.ReadLine());


        //declaring 2D array
        int[,] arr = new int[rows, col];


        //adding elemet trough user Input 
        for(int i =0; i<rows; i++)
        {
            for(int j =0; j<col; j++)
            {
                Console.WriteLine($"{i}{j} element");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        //for printing

        for(int i =0; i<rows; i++)
        {
            for(int j = 0; j<col; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }



    }
}