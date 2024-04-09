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
        Console.WriteLine("Числа Фібоначі");
        Console.Write(0);
        Console.Write(new string(' ', 3));

        int n1 = 0,
            n2 = 1,
        currNum = 1;
        for (int i = 0; currNum <= userInput; i++)
        {
            Console.Write(currNum);
            Console.Write(new string(' ', 3));
            currNum = n1 + n2;
            n1 = n2;
            n2 = currNum;
        }
    }

    private static int GetUserInput()
    {
        Console.WriteLine("Введіть число");
        var result = Convert.ToInt32(Console.ReadLine());
        return result;
    }
}