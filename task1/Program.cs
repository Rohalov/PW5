
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
        List<double> dividers = new List<double>();
        for (int i = 1; i <= number; i++)
        {
            var div = number / i;
            if (Math.Round(div, 0) == div)
            {
                dividers.Add(div);
            }
        }
        return dividers.Count == 2;
    }

    private static double GetUserInput()
    {
        Console.WriteLine("Введіть число");
        var result = Convert.ToDouble(Console.ReadLine());
        return result;
    }
}