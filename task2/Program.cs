internal class Program
{
    private static void Main(string[] args)
    {
        var userInput = GetUserInput();

        ShowFibonachiNumbers(userInput);

        Console.ReadKey();
    }

    private static void ShowFibonachiNumbers(int userInput)
    {
        List<int> fibonachiNumbers = GetFibLessNum(userInput);
        Console.WriteLine("Числа Фібоначі");
        foreach (int number in fibonachiNumbers)
        {
            Console.Write(number);
            Console.Write(new string(' ', 3));
        }
    }

    private static List<int> GetFibLessNum(int number)
    {
        List<int> fibnums = new List<int> { 0 };
        int currNum = 1;
        int i = 1;
        while (currNum <= number)
        {
            fibnums.Add(currNum);
            currNum = fibnums[i] + fibnums[i - 1];
            i++;
        }
        return fibnums;
    }

    private static int GetUserInput()
    {
        Console.WriteLine("Введіть число");
        var result = Convert.ToInt32(Console.ReadLine());
        return result;
    }
}