using System;

class Employee
{
    public string LastName;
    public string FirstName;
    public string MiddleName;
    public string Address;
    public int HireYear;
    public string Post;
    public Employee(string LastName, string FirstName, string MiddleName, string Address, int HireYear, string Post) 
    {
        this.LastName = LastName;
        this.FirstName = FirstName;
        this.MiddleName = MiddleName;
        this.Address = Address;
        this.HireYear = HireYear;
        this.Post = Post;
    }
}