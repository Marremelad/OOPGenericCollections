namespace OOPGenericCollections;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> listOfEmployees =
        [
            new Employee("101", "Anas", Employee.EmployeeGender.Male, 50000),
            new Employee("102", "Hanna", Employee.EmployeeGender.Female, 40000),
            new Employee("103", "Tobias", Employee.EmployeeGender.Male, 30000),
            new Employee("104", "Sara", Employee.EmployeeGender.Female, 20000),
            new Employee("105", "Anna", Employee.EmployeeGender.Female, 500000)
        ];

        Stack<Employee> stackOfEmployees = new Stack<Employee>(listOfEmployees);
        
        foreach (var employee in stackOfEmployees)
        {
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            Console.WriteLine($"items left in the stack = {stackOfEmployees.Count}");
        }
        Console.WriteLine("------------------------------");
        
        Console.WriteLine("Retrieve Using Pop Method");
        while (stackOfEmployees.Count > 0)
        {
            var employee = stackOfEmployees.Pop();
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
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
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
            Console.WriteLine($"Items left in the stack = {stackOfEmployees.Count}");
        }
        Console.WriteLine("------------------------------");

        for (int i = 0; i < listOfEmployees.Count; i++)
        {
            Console.WriteLine(stackOfEmployees.Contains(listOfEmployees[i]) ? $"Emp{i + 1} is in the stack" : $"Emp{i + 1} is not in the stack" );
        }
        Console.WriteLine("------------------------------");

        Employee newEmployee = new Employee("106", "Mike", Employee.EmployeeGender.Male, 1000000);
        listOfEmployees.Add(newEmployee); // Comment out this line to not add newEmployee to the list.
        Console.WriteLine(listOfEmployees.Contains(newEmployee) ? $"Employee {newEmployee.Id} exists in the list" : $"Employee {newEmployee.Id} does not exist in the list");
        Console.WriteLine("------------------------------");

        var maleEmployee = listOfEmployees.Find(e => e.Gender == Employee.EmployeeGender.Male);
        Console.WriteLine(maleEmployee != null ? $"Found one male employee:\nID = {maleEmployee.Id}, Name = {maleEmployee.Name}, Salary = {maleEmployee.Salary:c}" : "No male employee found");
        Console.WriteLine("------------------------------");

        var maleEmployees = listOfEmployees.FindAll(e => e.Gender == Employee.EmployeeGender.Male);
        if (maleEmployees.Count > 0)
        {
            Console.WriteLine($"Found {maleEmployees.Count} male employees:");
            foreach (var employee in maleEmployees)
            {
                Console.WriteLine($"ID = {employee.Id}, Name = {employee.Name}, Salary = {employee.Salary:c}");
            }
        }
        else Console.WriteLine("No male employees found");
    }
}