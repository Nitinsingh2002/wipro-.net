namespace jaggedArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //declaring a simple jagged aaray 
            //array each row will be new arary

            //int[][] jagged = new int[4][];

            ////initilize each row with differnet number of element 
            //jagged[0] = new int[] { 1, 2, 4, 5 };
            //jagged[1] = new int[] { 2, 3, 5, 6 };
            //jagged[2] = new int[] { 7, 8, 9, 10 };
            //jagged[3] = new int[] { 11, 12, 34, 55, 41 };

            ////printing the jagged array

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    Console.WriteLine($"row is {i + 1}");
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write(jagged[i][j] + " ");
            //    }

            //    Console.WriteLine();
            //}


            //example 2 getting input from users 


            Console.WriteLine("Enter number of team");
            int teams = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[teams][];

            for(int i =0; i < teams; i++)
            {
                Console.WriteLine($"number of round played by teams {i + 1}");
                int rounds = Convert.ToInt32(Console.ReadLine());
                jaggedArray[i] = new int[rounds];

                Console.WriteLine($"Enter the scores for each round of team {i + 1}");

                for(int j =0; j < rounds; j++)
                {
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }



            //display the score 
            for(int i =0; i < jaggedArray.Length; i++)
            {
                int sum = 0;
                for(int j =0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                    sum = sum + jaggedArray[i][j];
                }

                Console.WriteLine("Total score of team is ",sum);
                Console.WriteLine();
            }




        }
    }
}