namespace EmployeeManagementSystem;

public class Developer : Employee
{
    public Developer(string name, int age, int id, double salary, DateTime hireDate) : base(name, age, id, salary, hireDate)
    { }

    public override int CalculateSalary() => 30 * 100000;
}
