using System;

class EmployeeHelper
{
    public List<Employee> SearchGreatestExperience(List<Employee> employees)
    {
        List<Employee> list = new List<Employee>();
        int counter = employees[0].HireYear;
        foreach(var employee in employees)
        {
            if (employee.HireYear < counter)
            {
                counter = employee.HireYear;
            }
        }
        foreach(var employee in employees)
        {
            if (employee.HireYear == counter)
            {
                list.Add(employee);
            }
        }
        return list;
    }
    public List<Employee> FindEmployeePost(List<Employee> employees, string post)
    {
        List<Employee> postsEmployee = new List<Employee>();
        foreach(var employee in employees)
        {
            if (employee.Post == post)
            {
                postsEmployee.Add(employee);
            }
        }
        return postsEmployee;
    }
    public void PrintEmployees(List<Employee> employees)
    {
        foreach(var employee in employees)
        {
            PrintEmployee(employee);
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