using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem;

namespace BankSystem.CEOFolder
{
    public interface ICeo
    {
        void control(string fullname);  
        void organize(string fullname);  
        void makeMeeting(string fullname);  
        void decreasePercentage(string fullname);  
    }

    public class Ceo : Employee, ICeo
    {
        public Ceo(Guid id, string name, string surname, int age, string position, decimal salary) 
            : base(id, name, surname, age, position, salary) {  }

        public void control(string fullname) => Console.WriteLine($"{fullname} Control");
        public void decreasePercentage(string fullname) => Console.WriteLine($"{fullname} decrease Percentage");
        public void makeMeeting(string fullname)  => Console.WriteLine($"{fullname} make Meeting");
        public void organize(string fullname) => Console.WriteLine($"{fullname} organize");
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
