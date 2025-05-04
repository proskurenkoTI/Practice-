using System;

public class Program
{
    public static void Main()
    {
        string maxInput = "";
        int maxLenInput = 0;
        introdctoryInformation();
        findBiggestWord(ref maxInput, ref maxLenInput);
        outputResult(maxInput, maxLenInput);

    }
    public static void findBiggestWord(ref string maxInput, ref int maxLenInput)
    {
        string input = string.Empty;
        int lenInput = 0;
        while ((input = Console.ReadLine()) != "exit")
        {
            lenInput = input.Length;
            if (lenInput > maxLenInput)
            {
                maxLenInput = lenInput;
                maxInput = input;
            }
        }
    }
    public static void introdctoryInformation()
    {
        Console.WriteLine("Вводите слово, завершая каждое нажатием Enter.");
        Console.WriteLine("Для выходя наберите \"exit\".");
    }
    public static void outputResult(string maxInput, int maxLenInput)
    {
        Console.WriteLine("Считывание завершено.");
        Console.WriteLine($"Самое длинное слово: \"{maxInput}\" ({maxLenInput})");
    }
}