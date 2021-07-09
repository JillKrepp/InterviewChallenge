using System;

namespace ConsoleApp1
{
    class Program
    {
        /* Create a function that takes two parameters.
         * The first parameter is an integer. The second parameter is a collection of integers. Without sorting the collction,
         * the function should return the number from the collection that is the closest to the integer parameter
        */



        static void Main(string[] args)
        {
            var output = ClosestNumber(5, new int[] {5, 10, 12});     
            var output1 = ClosestNumber(2, new int[] { 0, 2, 3 });    
            var output2 = ClosestNumber(-12, new int[] { -1, 0, 7, -4, -20, 3 });
            var output3 = ClosestNumber(7, new int[] { 1, -4, 7, 8 });
            Console.WriteLine(output);
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
            Console.ReadKey();
        }

        public static int ClosestNumber(int number, int[] collection)
        {
            //Define int to contain the closest located number
            int closestNumber = 0;
            int closestGap = 0; 
            // For loop to iterate over collection
            for (int i = 0; i < collection.Length; i++)
            {
                //Value to contain the distance between each value in the collection.
                // -> Math abs needs to be used to convert to postive number
                var gap = Math.Abs(number - collection[i]);
                
                //Short circuit if we find an exact match
                if (gap == 0)
                    return collection[i];
                    
                //Evaluate if the current distance is less then the prior values. If so, save the Gap and Value
                if (closestGap > gap)
                {
                    closestGap = gap;
                    closestNumber = collection[i];
                }
                             
            }
            return closestNumber;
        }



    }
}
