namespace CompositePattern;

public class Manager : IEmployee
{
    private string name;
    private double salary;
    private List<IEmployee> employees = new List<IEmployee>();

    public Manager(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public void Add(IEmployee employee)
    {
        employees.Add(employee);
    }

    public void Remove(IEmployee employee)
    {
        employees.Remove(employee);
    }
    public string GetName()
    {
        return name;
    }

    public double GetSalary()
    {
        return salary;
    }

    public List<IEmployee> GetEmployees()
    {
        return employees;
    }
}