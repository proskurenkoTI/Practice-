using Microsoft.VisualBasic;
using System;


public class StoreDataTask
{
    public double a { get; }
    public double b { get; }
    public double c { get; }

    public StoreDataTask(double a, double b, double c)
    {
        this.a = a; this.b = b; this.c = c;
    }
}

public class SolutionMethods
    // поля в верхнем блоке сначала приватные потом публичные
    // методы сначала публичные потом приватные 
{
    private StoreDataTask _fridge;
    private double discriminant;

    public StoreDataSolution SolveQuadrEquation(StoreDataTask fridge)
    {
        _fridge = fridge;
        CalculateDiscriminant();

        if (_fridge.a <= 0)
        {
            return new StoreDataSolution(-1);
        }
        else if (discriminant > 0)
        {
            double x1 = CalculateFirstRoot();
            double x2 = CalculateSecondRoot();
            return new StoreDataSolution(x1, x2, 2);
        }
        else if (discriminant == 0)
        {
            double x = CalculateSingleRoot();
            return new StoreDataSolution(x, 1);
        }
        else
        {
            return new StoreDataSolution(3);
        }
    }
    private void CalculateDiscriminant()
    {
        discriminant = Math.Pow(_fridge.b, 2) - 4 * _fridge.a * _fridge.c;
    }
    private double CalculateFirstRoot()
    {
        return (-_fridge.b + Math.Sqrt(discriminant)) / (2 * _fridge.a);
    }
    private double CalculateSecondRoot()
    {
        return (-_fridge.b - Math.Sqrt(discriminant)) / (2 * _fridge.a);
    }
    private double CalculateSingleRoot()
    {
        return -_fridge.b / (2 * _fridge.a);
    }
}

public class StoreDataSolution
{
    public double x1;
    public double x2;
    public double x;
    public int typeSolution;
    public StoreDataSolution(double x1, double x2, int typeSolution)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.typeSolution = typeSolution;
    }
    public StoreDataSolution(double x, int typeSolution)
    {
        this.x = x;
        this.typeSolution = typeSolution;
    }
    public StoreDataSolution(int typeSolution)
    {
        this.typeSolution = typeSolution;
    }
}

public class Program2
{
    public static void Main()
    {
        double a;
        double b;
        double c;

        ReadData(out a, out b, out c);
        StoreDataTask task = new StoreDataTask(a, b, c);
        SolutionMethods solver = new SolutionMethods();
        StoreDataSolution solution = solver.SolveQuadrEquation(task);
        PrintSolution(solution);
    }
    public static void ReadData(out double a, out double b, out double c)
    {
        string input;
        bool isValidInput;
        do 
        {
            Console.WriteLine("Введите а:");
            input = Console.ReadLine();
            isValidInput = double.TryParse(input, out a);
            if (!isValidInput)
            {
                Console.WriteLine("Некорректный ввод.");
            }
        } while (!isValidInput);
        do
        {
            Console.WriteLine("Введите b:");
            input = Console.ReadLine();
            isValidInput = double.TryParse(input, out b);
            if (!isValidInput)
            {
                Console.WriteLine("Некорректный ввод.");
            }
        } while (!isValidInput);
        do
        {
            Console.WriteLine("Введите c:");
            input = Console.ReadLine();
            isValidInput = double.TryParse(input, out c);
            if (!isValidInput)
            {
                Console.WriteLine("Некорректный ввод.");
            }
        } while (!isValidInput);
    }
    public static void PrintSolution(StoreDataSolution solution)
    {
        if (solution.typeSolution == 1)
        {
            Console.WriteLine($"Уравнение имеет один корень: {solution.x}");
        }
        else if (solution.typeSolution == 2)
        {
            Console.WriteLine($"Уравнение имеет два корня: {solution.x1}, {solution.x2}");
        }
        else if (solution.typeSolution == 3)
        {
            Console.WriteLine("Уравнение не имеет корней");
        }
        else if (solution.typeSolution == -1)
        {
            Console.WriteLine("Коэф. а не может быть отриц.");
        }
    }
}
