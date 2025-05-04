using System;

public class Program
{
    public static void Main()
    {
        double temperature;
        string scaleValue = string.Empty;

        dataReading(out temperature, out scaleValue);
        outputResult(scaleValue, temperature);
    }
    public static void dataReading(out double temperature, out string scaleValue)
    {
        string input = string.Empty;

        bool isValidInput;
        do
        {
            Console.Clear();
            Console.Write("Введите значение температуры: ");
            input = Console.ReadLine();
            isValidInput = double.TryParse(input, out temperature);
            Console.Write("Введите значение шкалы: ");
            scaleValue = Console.ReadLine();
            if (!isValidInput || (scaleValue.ToUpper() != "C" && scaleValue.ToUpper() != "F"))
            {
                Console.WriteLine("Некоректный ввод");
                Console.ReadKey();
            }
        }
        while (!isValidInput || (scaleValue.ToUpper() != "C" && scaleValue.ToUpper() != "F"));
    }
    public static void outputResult(string scaleValue, double temperature)
    {
        if (scaleValue == "C" || scaleValue == "c")
        {
            Console.WriteLine($"Результат: {Math.Round((temperature * 9) / 5 + 32)}F");
        }
        else if (scaleValue == "F" || scaleValue == "f")
        {
            Console.WriteLine($"Результат:  {Math.Round((temperature - 32) * 5 / 9)}C");
        }
        Console.ReadKey();
    }
}