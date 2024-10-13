namespace OOPGenericCollections;

// Employee class.
public class Employee
{
    public string? Id { get; set; } // Employee ID.
    public string? Name { get; set; } // Employee name.
    public EmployeeGender Gender { get; set; } // Employee gender.
    public decimal Salary { get; set; } // Employee salary.

    // Enum to define gender options.
    public enum EmployeeGender
    {
        Male,
        Female,
        Other,
    }

    // Constructor to initialize an Employee object.
    public Employee(string id, string name, EmployeeGender gender, decimal salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }
}