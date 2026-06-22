using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.CLIENTFolder;

namespace BankSystem.CREDITFolder
{
    public class Credit
    {
        public Guid _Id { get; set; }
        public Client? _Client { get; set; }
        public decimal _Amount { get; set; }
        public decimal _Percent { get; set; }
        public int _Month { get; set; } 

        public Credit(Guid ıd, Client? client, decimal amount, decimal percent, int month)
        {
            _Id = ıd;
            _Client = client;
            _Amount = amount;
            _Percent = percent;
            _Month = month;
        }


        public decimal CalculatePercent()
        {
            decimal total = _Amount + (_Amount * _Percent / 100);   
            return total / _Month;
        }

        public void Payment()
        {
            decimal monthly = CalculatePercent();
            Console.WriteLine($"Monthly payment: ${monthly:F2}");
            Console.WriteLine($"Total amount: ${_Amount + (_Amount * _Percent / 100):F2}");
        }

        public override string ToString() => $@"
Client:         {_Client}
Credit Id:      {_Id}
Amount:         {_Amount}
Percent:        {_Percent}
Month:          {_Month}
";
    }
}
