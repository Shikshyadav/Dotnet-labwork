using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Factorial
    {
        public void takefactorial()
        {
            Console.Write("Enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = num1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("The factorial of " + num1 + " is: " + factorial);
        }
    }
}