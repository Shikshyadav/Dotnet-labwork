
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class GreatestNum
    {
        public void greatest()
        {
            int a = 20;
            int b = 30;
            int c = 40;

            Console.WriteLine("Finding the greatest number among the numbers");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            if (a > b)
            {
                Console.WriteLine("a is the greatest number" + a);

            }
            else if (b > c)
            {
                Console.WriteLine("b is the greatest number" + b);

            }
            else
            {
                Console.WriteLine("c is the greatest number" + c);

            }

        }

    }
}
