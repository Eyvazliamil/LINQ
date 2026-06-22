using BankSystem.OPERATIONFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.WORKERFolder
{
    public class Worker : Employee
    {
        public string _StartTime  { get; set; }
        public string _EndTime  { get; set; }
        public List<Operation> Operations { get; set; } = new List<Operation>();
        public Worker(Guid id, string name, string surname, int age, string position, decimal salary, string startTime, string endTime)
            : base(id, name, surname, age, position, salary)
        {
            _StartTime = startTime;
            _EndTime = endTime;
        }
        public void AddOperation(Operation operation)
        {
            Operations.Add(operation);
            Console.WriteLine($"Operation added: {operation._processName}");
        }
        public override string ToString() => @$"
Id:             {_Id}
Name:           {_Name}
Surname:        {_Surname}
Age:            {_Age}
Position:       {_Position}
Salary:         {_Salary}
Start Time:     {_StartTime}
End Time:       {_EndTime}
";
    }
}
