using System;

public class Program1
{
    public static void Main()
    {
        ushort year = requestYear();
        bool answer = checkLeapYear(year);
        solutionOutput(answer, year);
    }
    public static ushort requestYear()
    {
        string input = string.Empty;
        bool isValidInput;
        ushort y;
        do
        {
            Console.Clear();
            Console.Write("Введите год: ");
            input = Console.ReadLine();
            isValidInput = ushort.TryParse(input, out y);
            if (!isValidInput)
            {
                Console.WriteLine("Некоректный ввод");
                Console.ReadKey();
            }
        }
        while (!isValidInput);
        return y;
    }
    public static bool checkLeapYear(ushort _year)
    {
        return ((_year % 4 == 0 && _year % 100 != 0) || (_year % 400 == 0));
    }
    public static void solutionOutput(bool _answer, ushort _year)
    {
        if (_answer)
        {
            Console.WriteLine($"{_year} - високосный год");
        }
        else
        {
            Console.WriteLine($"{_year} - невисокосный год");
        }
        Console.ReadKey();
    }
}

