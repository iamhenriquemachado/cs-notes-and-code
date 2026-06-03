using cs_notes_and_code.challenges.EmployeeSystem;

Employee e = new Manager("Henrique de Castro Machado", 5000.0m);

var bonus = e.GetBonus();

Console.WriteLine($"This is your bonus: ${bonus}");