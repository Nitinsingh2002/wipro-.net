internal class Program
{
    private static void Main(string[] args)
    {
        //// multi dimensional array
        //Console.WriteLine("Enter row of your two dimensional araay");
        //int row = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter column of your two dimensional araay");
        //int col = Convert.ToInt32(Console.ReadLine());

        //int[,] arr = new int[row, col];

        ////taking input from user for filling the array 
        //for( int i =0; i < row; i++)
        //{
        //    for(int j=0; j<col; j++)
        //    {
        //        Console.WriteLine($"enter the number you want to add to {i} {j} position");
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        arr[i, j] = num;
        //    }
        //}


        ////to print multidimensional array 
        //for(int i =0; i < row; i++)
        //{
        //    for(int j =0; j < col; j++)
        //    {
        //        Console.Write(arr[i, j]);
        //    }
        //    Console.WriteLine();
        //}



        // *******************************jagged array *******************************************
        //int[][] arr = new int[2][];
        //// initlizing each row of jagged array always jageed array row iare intilized like that
        //    arr[0] =new int[] { 1,2,6,8};
        //   arr[1] = new int[] { 1, 2 };

        ////printing jagged array
        ////for loop for outer 
        //for(int i =0; i < arr.Length; i++)
        //{
        //    //for loop for each row we have to find length of each row because each row have differnt lenght
        //    for(int j =0; j < arr[i].Length; j++)
        //    {
        //        Console.Write(arr[i][j]);
        //    }
        //    Console.WriteLine();

        //}



        // taking input in jagged array



        //Console.WriteLine("Enter the number of row of jagged array");
        //int row = Convert.ToInt32(Console.ReadLine());
        //int[][] jaggedArray = new int[row][];

        ////taking input via user 
        //for( int i = 0; i < jaggedArray.Length; i++)
        //{
        //    Console.WriteLine("Enter the number of element for {i+1} row ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    jaggedArray[i] = new int[num];


        //    for(int j =0; j < jaggedArray[i].Length; j++)
        //    {
        //        Console.WriteLine($"Enter {j + 1} element for {i + 1} row");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        jaggedArray[i][j] = n;
        //    }
        //}



        ////displaying 
        //for(int i =0;  i < jaggedArray.Length; i++)
        //{for( int j = 0; j < jaggedArray[i].Length; j++)
        //    {
        //        Console.Write(jaggedArray[i][j]);
        //    }
        //    Console.WriteLine();

        //}



        // how to pass array to afunction 

        int[] arr = { 1, 2, 4 };
        print(arr);

    }


    public static void print(int[] arr)
    {
        for(int i =0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}