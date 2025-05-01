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
{
    private StoreDataTask _fridge;
    private double discriminant;

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

    public SolutionMethods(StoreDataTask fridge)
    {
        _fridge = fridge;
    }
    public StoreDataSolution SolveQuadrEquation()
    {
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
        string input;
        double a;
        double b;
        double c;
        bool isValidInput;
        Console.WriteLine("Введите а:");
        input = Console.ReadLine();
        isValidInput = double.TryParse(input, out a);
        Console.WriteLine("Введите b:");
        input = Console.ReadLine();
        isValidInput = double.TryParse(input, out b);
        Console.WriteLine("Введите c:");
        input = Console.ReadLine();
        isValidInput = double.TryParse(input, out c);
        
        StoreDataTask task = new StoreDataTask(a, b, c);
        SolutionMethods solver = new SolutionMethods(task);
        StoreDataSolution solution = solver.SolveQuadrEquation();
        PrintSolution(solution);
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
