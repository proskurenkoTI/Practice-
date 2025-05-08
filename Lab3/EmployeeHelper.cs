using System;

class EmployeeHelper
{
    public List<Employee> SearchGreatestExperience(List<Employee> employees)
    {
        Dictionary<Employee, int> result = new Dictionary<Employee, int>();
        List<Employee> conclusion = new List<Employee>();
        foreach (var employee in employees)
        {
            result[employee] = (2025 - employee.HireYear);
        }
        int counter = 0;
        foreach (var employee in result) 
        {
            if (employee.Value > counter)
            {
                counter = employee.Value;
            }
        }
        foreach (var employee in result)
        {
            if (employee.Value == counter)
            {
                conclusion.Add(employee.Key);
            }
        }
        return conclusion;
    }
    public void PrintEmployeePost(List<Employee> employees, string post)
    {
        foreach(var employee in employees)
        {
            if (employee.Post == post)
            {
                PrintEmployee(employee);
            }
        }
    }
    public void PrintEmployee(Employee employee)
    {
        Console.WriteLine(employee.FirstName);
        Console.WriteLine(employee.LastName);
        Console.WriteLine(employee.MiddleName);
        Console.WriteLine(employee.Address);
        Console.WriteLine(employee.HireYear);
        Console.WriteLine(employee.Post);
    }
    public List<Employee> SortByValue(List<Employee> list)
    {
        int n = list.Count;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                Employee temp = list[i];
                int j;
                for (j = i; j >= gap && list[j - gap].HireYear < temp.HireYear; j -= gap)
                {
                    list[j] = list[j - gap];
                }
                list[j] = temp;
            }
            gap /= 2;
        }
        return list;
    }
}