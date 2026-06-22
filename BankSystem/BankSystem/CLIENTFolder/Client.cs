using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.CLIENTFolder
{
    public class Client : Person
    {
        public string _liveAddress { get; set; }
        public string _workAddress { get; set; }
        public decimal _Salary { get; set; }
        public Client(Guid id, string name, string surname, int age, string lA, string wA, decimal salary) : base(id, name, surname, age)
        {
            _liveAddress = lA;
            _workAddress = wA;
            _Salary = salary;
        } 
        public override string ToString() => @$"
Id:             {_Id}
Name:           {_Name}
Surname:        {_Surname}
Age:            {_Age}
Live Address:   {_liveAddress}
Work Address:   {_workAddress}
Salary:         {_Salary} 
        ";
    }
}
