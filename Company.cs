namespace CompositePattern;

public class Company
{

    public void PrintEmployeesGetTotalSalary()
    {
        // Creating developers
        IEmployee dev1 = new Developer("Dev1", 10000);
        IEmployee dev2 = new Developer("Dev2", 15000);

        // Creating a manager and adding developers to his team
        IEmployee cto = new Manager("Craig Federighi", 25000);
        cto.Add(dev1);
        cto.Add(dev2);

        // Creating another manager (CEO) and adding the first manager to his team
        Manager ceo = new Manager("Tim Cook", 50000);
        ceo.Add(cto);
        double totalSalary = 0;
        // Displaying CEO's details
        Console.WriteLine(ceo.GetName());
        Console.WriteLine("CEO's Salary: " + ceo.GetSalary());
        totalSalary += ceo.GetSalary();
        // Displaying team members' details under CEO
        Console.WriteLine("Team members under CEO:");
        foreach (IEmployee employee in ceo.GetEmployees())
        {
            Console.WriteLine(employee.GetName() + " with salary: " + employee.GetSalary());
            totalSalary += employee.GetSalary();

            // If the employee is a manager, display his team members' details
            if (employee is Manager)
            {
                Console.WriteLine("Team members under " + employee.GetName() + ":");
                foreach (IEmployee emp in ((Manager)employee).GetEmployees())
                {
                    Console.WriteLine(emp.GetName() + " with salary: " + emp.GetSalary());
                    totalSalary += emp.GetSalary();
                }
            }
        }
        System.Console.WriteLine("Total Salary: " + totalSalary);


    }
}