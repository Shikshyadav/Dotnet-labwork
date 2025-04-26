using lab_4;

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperations mathOperation = new MathOperations();
        int addvalue = mathOperation.Add(3, 4);
        double addedvalue = mathOperation.Add(12.54, 12.466);
        int product = mathOperation.Multiply(3, 4);
        double decimal_product = mathOperation.Multiply(10.02, 25.5);
        Console.WriteLine($"The int type add value is {addvalue}");
        Console.WriteLine($"The doubleint type add value is {addedvalue}");
        Console.WriteLine($"The multiply type add value is {product}");
        Console.WriteLine($"The doublemultiply type add value is {decimal_product}");

        Console.ReadKey();
        Console.Clear();

        MathOperation inheritance = new MathOperation();
        double add = inheritance.Add(9.5, 5);
        double sub = inheritance.Subtract(8.5, 3);
        double mul = inheritance.Multiply(2.5, 4);
        double div = inheritance.Divide(25, 2.5);
        Console.WriteLine($"Add = {add}, Subtract = {sub}, Multiply = {mul}, Divide = {div}");

        Console.ReadKey();
        Console.Clear();

        Palindrome checkingPalindrome = new Palindrome();
        checkingPalindrome.checkPalindrome();

        Console.ReadKey();
        Console.Clear();

    }
}