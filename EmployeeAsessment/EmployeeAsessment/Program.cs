using EmployeeAsessment;
using System.Reflection.Metadata.Ecma335;

Employee employee1 = new Employee("Adam", "Developer", 45);
Employee employee2 = new Employee("Zuzia", "Asisstant", 28);
Employee employee3 = new Employee("Damian", "Tester", 33);

employee1.Add5Grades(4, 3, 4, 7, 8);        
employee2.Add5Grades(3, 5, 5, 6, 2);
employee3.Add5Grades(2, 4, 2, 7, 4);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

// one version

if (result1 > result2)
{ if(result1 > result3)
    {
        Console.WriteLine($"Best grades are achieved by {employee1.FirstName} {employee1.LastName} with score {result1}.");
    }
else
    {
        Console.WriteLine($"NBest grades are achieved by {employee3.FirstName} {employee3.LastName} with score {result3}.");
    }
            }
else if (result2 > result3)

    {
        Console.WriteLine($"Best grades are achieved by {employee2.FirstName} {employee2.LastName} with score {result2}.");
    }
    else 
        {
        Console.WriteLine($"Best grades are achieved by {employee3.FirstName} {employee3.LastName} with score {result3}.");
    }

// second version
string firstName, lastName;
    int age;

List<int> results = new();
results.Add(result1);
results.Add(result2);
results.Add(result3);
int maxResult = results.Max();

if (maxResult == result1)
{
    firstName = employee1.FirstName;
    lastName = employee1.LastName;
    
    PrintMsg(firstName, lastName, maxResult);

}
else if (maxResult == result2)
{
    firstName = employee2.FirstName;
    lastName = employee2.LastName;

    PrintMsg(firstName, lastName, maxResult);

}
else if (maxResult == result3)
{
    firstName = employee3.FirstName;
    lastName = employee3.LastName;

    PrintMsg(firstName, lastName, maxResult);

}

static void PrintMsg(string firstName, string lastName, int maxResult)
{
    Console.WriteLine($"Best result is achieved by { firstName} { lastName }. The value is {maxResult}");
}