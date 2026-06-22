using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.OPERATIONFolder
{
    public class Operation
    {
        public Guid _Id { get; set; }
        public string _processName { get; set; }
        public DateTime _DateTime { get; set; }
        public Operation(Guid ıd, string processName, DateTime dateTime)
        {
            _Id = ıd;
            _processName = processName;
            _DateTime = dateTime;
        }
        public override string ToString() => @$"
Id:             {_Id}
Process:        {_processName}
Date & Time:    {_DateTime}
";
    }
}
