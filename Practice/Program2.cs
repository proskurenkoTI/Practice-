using Microsoft.VisualBasic;
using System;


public class StoreDataTask
{
    public double a { get; }
    public double b { get; }
    public double c { get; }
    public double dd;
     
    public StoreDataTask(double a, double b, double c)
    {
        if (a <= 0)
        {
            Console.WriteLine("Коэф. а не может быть отриц.");
        }
        else
        {
            this.a = a; this.b = b; this.c = c;
        } 
    }
}

public class SolutionMethods
{
    private StoreDataTask _fridge;
    private double discriminant;
    public static List<string> typeSolution = new List<string> { "oneRoot", "twoRoot", "noRoot" };

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

        if (discriminant > 0)
        {
            double x1 = CalculateFirstRoot();
            double x2 = CalculateSecondRoot();
            return new StoreDataSolution(x1, x2, typeSolution[1]);
        }
        else if (discriminant == 0) 
        {
            double x = CalculateSingleRoot();
            return new StoreDataSolution(x, typeSolution[0]);
        }
        else
        {
            return new StoreDataSolution(typeSolution[2]);
        }
    }
}

public class StoreDataSolution
{
    double x1;
    double x2;
    double x;
    string typeSolution;
    public StoreDataSolution(double x1, double x2, string typeSolution)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.typeSolution = typeSolution;
    }
    public StoreDataSolution(double x, string typeSolution)
    {
        this.x = x;
        this.typeSolution = typeSolution;
    }
    public StoreDataSolution(string typeSolution)
    {
        this.typeSolution = typeSolution;
    }
    public void PrintSolution()
    {
        if (typeSolution == "oneRoot")
        {
            Console.WriteLine($"Уравнение имеет один корень: {x}");
        }
        else if (typeSolution == "twoRoot")
        {
            Console.WriteLine($"Уравнение имеет два корня: {x1}, {x2}");
        }
        else if (typeSolution == "noRoot")
        {
            Console.WriteLine("Уравнение не имеет корней");
        }
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

        solution.PrintSolution();
    }
}
