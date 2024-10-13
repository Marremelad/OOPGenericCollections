namespace OOPGenericCollections;

public class Employee
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public EmployeeGender Gender { get; set; }
    public decimal Salary { get; set; }

    public enum EmployeeGender
    {
        Male,
        Female,
        Other,
    }

    public Employee(string id, string name, EmployeeGender gender, decimal salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }
    
    
}