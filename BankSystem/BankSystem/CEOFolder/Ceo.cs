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
        void control();  
        void organize();  
        void makeMeeting();  
        void decreasePercentage();  
    }

    public class Ceo : Employee, ICeo
    {
        public Ceo(Guid id, string name, string surname, int age, string position, decimal salary) 
            : base(id, name, surname, age, position, salary) {  }

        public void control() => Console.WriteLine("Ceo Control");
        public void decreasePercentage() => Console.WriteLine("Ceo decrease Percentage");
        public void makeMeeting()  => Console.WriteLine("Ceo make Meeting");
        public void organize() => Console.WriteLine("Ceo organize");
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
