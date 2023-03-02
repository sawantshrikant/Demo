using System;

class Program
{
    static void Main()
    {
        int num1 = 50;
        int num2 = 100;
        int num3 = 200;

        int greatest = num1;
        if (num2 > greatest)
        {
            greatest = num2;
        }
        if (num3 > greatest)
        {
            greatest = num3;
        }

        Console.WriteLine($"The greatest number is {greatest}.");
    }
}