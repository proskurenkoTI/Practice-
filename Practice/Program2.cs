using System;
using static System.Formats.Asn1.AsnWriter;

public class Program2
{
    public static void Main()
    { 
        int score = 0;
        int allEvent = 0;
        gameProcessing(ref score, ref allEvent);
        solutionOutput(score, allEvent);
    }
    public static void gameProcessing(ref int score, ref int allEvent)
    {
        Random orelReshka = new Random();
        string input = string.Empty;
        int numberInput;

        Console.WriteLine("Игра началась!");
        do
        {
            int randomValue = orelReshka.Next(2);
            Console.Write("Введите число: ");
            input = Console.ReadLine();
            numberInput = int.Parse(input);
            if (checkCorrect(numberInput))
            {
                if (numberInput == randomValue)
                {
                    Console.WriteLine("Угадали!");
                    score++;
                    allEvent++;
                }
                else
                {
                    Console.WriteLine("Попробуйте снова");
                    allEvent++;
                }
            }
        }
        while (checkCorrect(numberInput));
    }
    public static bool checkCorrect(int _num) { return (_num == 0 || _num == 1); }
    public static void solutionOutput(int _score, int _allEvent)
    {
        double percent = 1.0 * _score / _allEvent;
        Console.WriteLine($"Игра окончена со счетом {_score}, угадано {Math.Round(percent, 2) * 100}% бросков");
    }
}   