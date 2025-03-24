using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class SumOfArray
    {
        public void addarray()
        {
            Console.Write("Enter the number of numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Declare an integer array of size n
            int[] numbers = new int[n];


            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }


            Console.WriteLine("Sum of array elements: " + sum);
        }
    }
}