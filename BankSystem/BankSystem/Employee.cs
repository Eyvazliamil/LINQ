using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Employee : Person
    { 
        public string _Position { get; set; }
        public decimal _Salary { get; set; }
        public Employee(Guid id, string name, string surname, int age, string position, decimal salary) 
            : base(id, name, surname, age)
        {
            _Position = position;
            _Salary = salary;
        }
          
    }
}
