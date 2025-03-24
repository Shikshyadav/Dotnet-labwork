
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Swap
    {
        public void swapping()
        {
            int a = 20;
            int b = 30;
            int temp;
            Console.WriteLine("Before Swapping");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

    }
}
