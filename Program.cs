using cs_notes_and_code.challenges.EmployeeSystem;

List<Employee> employee = new List<Employee>();

employee.Add(new Manager("Jane Doe", 10.000m));
employee.Add(new SalesPerson("John Doe", 4.000m, 0.5m));
employee.Add(new Intern("Rick Doe", 1.000m));

foreach (var e in employee)

{
    if (e is Manager manager)
    {
        Console.WriteLine($"Manager Salary list: {manager.Name} - {manager.GetBonus()}");
    }
    if (e is SalesPerson salesPerson)
    {
        Console.WriteLine($"SalesPerson Salary list: {salesPerson.Name} - {salesPerson.GetBonus()}");
    }
    if (e is Intern intern)
    {
        Console.WriteLine($"Intern Salary list: {intern.Name} - {intern.GetBonus()}");
    }

}