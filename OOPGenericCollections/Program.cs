namespace OOPGenericCollections;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> listOfEmployees =
        [
            new Employee("101", "Jake", Employee.EmployeeGender.Male, 50000),
            new Employee("102", "Joice", Employee.EmployeeGender.Female, 40000),
            new Employee("103", "Jasper", Employee.EmployeeGender.Male, 30000),
            new Employee("104", "Jennifer", Employee.EmployeeGender.Female, 20000),
            new Employee("105", "John", Employee.EmployeeGender.Male, 500000)
        ];

        Stack<Employee> stackOfEmployees = Helper<Employee>.PushToStack(listOfEmployees);
        
        foreach (var employee in stackOfEmployees)
        {
            Console.WriteLine(employee.Name);
        }
    }
}