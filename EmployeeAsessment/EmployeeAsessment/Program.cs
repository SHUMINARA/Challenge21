using EmployeeAsessment;

Employee employee1 = new Employee("Adam", "Developer", 45);
Employee employee2 = new Employee("Zuzia", "Asisstant", 28);
Employee employee3 = new Employee("Damian", "Tester", 33);

employee1.AddGrade(4);
employee2.AddGrade(3);
employee3.AddGrade(2);
employee1.AddGrade(1);
employee2.AddGrade(9);
employee3.AddGrade(8);
employee1.AddGrade(7);
employee2.AddGrade(6);
employee3.AddGrade(5);
employee1.AddGrade(4);
employee2.AddGrade(3);
employee3.AddGrade(2);
employee1.AddGrade(1);
employee2.AddGrade(9);
employee3.AddGrade(8);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

if (result1 > result2)
{ if(result1 > result3)
    {
        Console.WriteLine($"Najlepsze oceny osiaga {employee1.FirstName} {employee1.LastName} z wynikiem {result1}.");
    }
else
    {
        Console.WriteLine($"Najlepsze oceny osiaga {employee3.FirstName} {employee3.LastName} z wynikiem {result3}.");
    }
            }
else if (result2 > result3)

    {
        Console.WriteLine($"Najlepsze oceny osiaga {employee2.FirstName} {employee2.LastName} z wynikiem {result2}.");
    }
    else
    {
        Console.WriteLine($"Najlepsze oceny osiaga {employee3.FirstName} {employee3.LastName} z wynikiem {result3}.");
    }