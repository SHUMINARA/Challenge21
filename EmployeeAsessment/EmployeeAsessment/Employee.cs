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
        public void Add5Grades(int number1, int number2, int number3, int number4, int number5) 
        {
            this.grade.Add(number1);
            this.grade.Add(number2);
            this.grade.Add(number3);
            this.grade.Add(number4);
            this.grade.Add(number5);

        }
    }
}
