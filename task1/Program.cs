
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var userInput = GetUserInput();

        if (isPrime(userInput))
        {
            Console.WriteLine($"Число {userInput} є простим");
        }
        else
        {
            Console.WriteLine($"Число {userInput} не є простим");
        }

        Console.ReadKey();
    }

    private static bool isPrime(double number)
    {
        if (number <= 3)
        {
            return number > 1;
        }
        else if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }
        else
        {
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    private static double GetUserInput()
    {
        Console.WriteLine("Введіть число");
        var result = Convert.ToDouble(Console.ReadLine());
        return result;
    }
}