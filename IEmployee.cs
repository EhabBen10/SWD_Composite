namespace CompositePattern;
public interface IEmployee
{
    void Add(IEmployee employee);
    void Remove(IEmployee employee);
    string GetName();
    double GetSalary();
}
