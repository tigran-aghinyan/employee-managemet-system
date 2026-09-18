namespace EmployeeManagementSystem;

public abstract class Employee
{
    public required string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }

    public Employee() { }
    public Employee(string name, int age, int id, double salary, DateTime hireDate)
    {
        Name = name;
        Age = age;
        Id = id;
        Salary = salary;
        HireDate = hireDate;
    }

    public abstract int CalculateSalary(); 
}
