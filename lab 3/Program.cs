using System;
using ConsoleApp1;
//using lab_3.sample;

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperation o1 = new MathOperation();
        double doubleAddResult = o1.Add(5.4, 10.5);
        Console.WriteLine("Result is  " + doubleAddResult);

     
        Console.ReadKey();

      


    }
}


