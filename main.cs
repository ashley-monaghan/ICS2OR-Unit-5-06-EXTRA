using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function accepts user input
        double firstNumber;
        double secondNumber;
        Console.Write("Enter two numbers to find the product!");
        Console.WriteLine("");
        Console.Write("Enter the first number:");
        firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        secondNumber = Convert.ToDouble(Console.ReadLine());
        double product = 0;
        double counter = 0;
        while (counter < Math.Abs(secondNumber))
        {
            counter++;
            product = product + Math.Abs(firstNumber);
        }
        if ((firstNumber < 0 && secondNumber > 0) || (secondNumber < 0 && firstNumber > 0))
        {
            Console.WriteLine("-" + product);
        }
        else
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("");
        Console.Write("/Done");
    }
}