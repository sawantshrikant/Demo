using System;

namespace MyProgram
{
    class Primeno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 0 and 100:");

            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
