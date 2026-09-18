namespace EmployeeManagementSystem;

public class Manager : Employee
{
    public Manager(string name, int age, int id, double salary, DateTime hireDate) : base(name, age, id, salary, hireDate)
    { }

    public override int CalculateSalary() => 30 * 10000;
}
