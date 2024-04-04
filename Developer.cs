namespace CompositePattern;

public class Developer : IEmployee
{
    private string name;
    private double salary;

    public Developer(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public void Add(IEmployee employee)
    {
        throw new NotImplementedException("Cannot add to a developer");
    }

    public void Remove(IEmployee employee)
    {
        throw new NotImplementedException("Cannot remove from a developer");
    }
    public string GetName()
    {
        return name;
    }

    public double GetSalary()
    {
        return salary;
    }
}