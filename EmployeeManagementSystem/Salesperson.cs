namespace EmployeeManagementSystem;

public class SalesPerson : Employee
{
    public SalesPerson(string name, int age, int id, double salary, DateTime hireDate) : base(name, age, id, salary, hireDate)
    { }

    public override int CalculateSalary() => 30 * 20000;
}
