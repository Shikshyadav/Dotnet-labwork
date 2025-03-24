using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Prime()

    {
        public void checkprime()
        {
            Console.Write("Enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrime(num) ? $"{num} is a prime number." : $"{num} is not a prime number.");
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i * i <= num; i++)
                if (num % i == 0) return false;
            return true;
        }
    }
}