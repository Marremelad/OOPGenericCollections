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

        Stack<Employee> stackOfEmployees = new Stack<Employee>(listOfEmployees);
        
        foreach (var employee in stackOfEmployees)
        {
            Console.WriteLine($"items left in the stack = {stackOfEmployees.Count}");
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} -  {employee.Salary}");
        }
        Console.WriteLine("------------------------------");
        
        Console.WriteLine("Retrieve Using Pop Method");
        while (stackOfEmployees.Count > 1)
        {
            var employee = stackOfEmployees.Pop();
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} -  {employee.Salary}");
            Console.WriteLine($"Items left in the stack = {stackOfEmployees.Count}");
        }
        Console.WriteLine("------------------------------");


        // stackOfEmployees = Helper<Employee>.PushToStack(listOfEmployees); // Use this line to have all employees in the stack.
        
        stackOfEmployees.Push(listOfEmployees[0]); // Use these three lines to only have three of the five employees in the stack. 
        stackOfEmployees.Push(listOfEmployees[1]);
        stackOfEmployees.Push(listOfEmployees[2]);
        
        Console.WriteLine("Retrieve Using Peek Method");
        for (int i = 0; i < 2; i++)
        {
            var employee = stackOfEmployees.Peek();
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} -  {employee.Salary}");
            Console.WriteLine($"Items left in the stack = {stackOfEmployees.Count}");
        }
        Console.WriteLine("------------------------------");

        for (int i = 0; i < listOfEmployees.Count; i++)
        {
            Console.WriteLine(stackOfEmployees.Contains(listOfEmployees[i]) ? $"Emp{i + 1} is in the stack" : $"Emp{i + 1} is not in the stack" );
        }
    }
}