using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class SumOfNum()

    {
        public void add()
        {

            Console.WriteLine("Enter the value of nth number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 0;

            for (int i = 0; i <= num1; i++)
            {
                num2 += i;
            }

            Console.WriteLine("The sum of the natural numbers is " + num2);


        }
    }
}