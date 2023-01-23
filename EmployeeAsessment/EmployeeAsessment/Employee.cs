using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAsessment
{
    public class Employee
    {
        private List<int> grade = new List<int>();

        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set;}
        public int Age { get; private set; }
        public int Result { get
            {
            return this.grade.Sum();}
    }
        public void AddGrade(int number) 
        {
            this.grade.Add(number);

        }
    }
}
