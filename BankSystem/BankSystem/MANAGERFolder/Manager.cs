using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem;

namespace BankSystem.MANAGERFolder
{
    public interface IManager
    { 
        void organize();
        void calculateSalaries();
    }
    public class Manager : Employee, IManager
    {
        public Manager(Guid id, string name, string surname, int age, string position, decimal salary) 
            : base(id, name, surname, age, position, salary)  {  } 
        public void calculateSalaries() => Console.WriteLine("Manager calculate Salaries"); 
        public void organize() => Console.WriteLine("Manager organize");

        public override string ToString() => @$"
Id:             {_Id}
Name:           {_Name}
Surname:        {_Surname}
Age:            {_Age}
Position:       {_Position}
Salary:         {_Salary}
        ";
    }
}
