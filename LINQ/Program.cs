﻿using System.Linq;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };

            // Define the query expression
            //var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            //List<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10).ToList();
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}