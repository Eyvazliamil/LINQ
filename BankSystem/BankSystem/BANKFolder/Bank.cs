using BankSystem.CEOFolder;
using BankSystem.CLIENTFolder;
using BankSystem.CREDITFolder;
using BankSystem.MANAGERFolder;
using BankSystem.WORKERFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystem.BANKFolder
{
    public class Bank(string nAME, decimal bUDGET, decimal pROFIT, Ceo? ceo = null)
    {
        public string _NAME { get; set; } = nAME;
        public decimal _BUDGET { get; set; } = bUDGET;
        public decimal _PROFIT { get; set; } = pROFIT;
        public Ceo? CEO { get; set; } = ceo;
        public List<Credit> Credits { get; set; } = new List<Credit>();  

        public void CALCULATE_PROFIT()
        {
            _PROFIT = 0;
            foreach (var credit in Credits)
            {
                _PROFIT += credit._Amount * credit._Percent / 100;
            }
            Console.WriteLine($"Total Profit: {_PROFIT:F2}");
        }
        public void showClientCredits(Credit credit)
        {
            Console.WriteLine($"Client: {credit._Client?._Name} {credit._Client?._Surname}");
            Console.WriteLine($"Amount: {credit._Amount}");
            Console.WriteLine($"Percent: {credit._Percent}%");
            Console.WriteLine($"Month: {credit._Month}");
            Console.WriteLine($"Monthly Payment: {credit.CalculatePercent():F2}");
        }
        public void payCredit (Credit credit, decimal money)
        {
            try
            {
                if (credit.CalculatePercent() > money)
                    throw new Exception("Insufficient money! Minimum: " + credit.CalculatePercent());

                if (credit._Client._Salary < credit.CalculatePercent())
                    throw new Exception("Insufficient Salary!");

                credit._Client._Salary -= credit.CalculatePercent();
                credit._Month--;
                _BUDGET += money;
                Console.WriteLine($"Payment successful! {credit._Month} months left.");

                if (credit._Month == 0)
                    Console.WriteLine("Credit closed!");
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
            }
        }
        public override string ToString() => @$"
Bank:             {_NAME}
Budget:           {_BUDGET}
Profit:           {_PROFIT}
Ceo --------------------------------              {CEO} 
";

    }
}
