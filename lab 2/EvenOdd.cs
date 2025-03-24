
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class EvenOdd
    {
        public void checkevenodd()
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());




            if (num1 % 2 == 1)
            {
                Console.WriteLine("num1 is odd");
            }
            else
            {
                Console.WriteLine("num1 is even");
            }
        }
    }
}
