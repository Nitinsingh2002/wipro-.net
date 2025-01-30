using System;

namespace WiproDay2ArrayDemo
{
    internal class Program
    {

        //instance method to find maximum element of array

        public int maximum(int[] arr)
        {
            int maxElement = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }
            return maxElement;
        }


        static void Main(string[] args)
        {

            //declaring array  by size
            int[] arr = new int[3];

            //declraing  array with elements
            int[] arr2 = { 1, 2, 4, 6, 7 };

            //accecing ecah element by for loop 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //calling static method
            showAll(arr2);


            //caling instance method 
            Program pg = new Program();
            pg.maximum(arr2);
        }


        // creating a function to show all elemenet of an arary 
        static void showAll(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}