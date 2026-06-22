using BankSystem.CEOFolder;
using BankSystem.CLIENTFolder;
using BankSystem.MANAGERFolder;
using BankSystem.WORKERFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.BANKFolder
{
    public class Bank(string nAME, decimal bUDGET, decimal pROFIT)
    {
        public string _NAME { get; set; } = nAME;
        public decimal _BUDGET { get; set; } = bUDGET;
        public decimal _PROFIT { get; set; } = pROFIT;
        public Ceo? CEO { get; set; }

        public void CALCULATE_PROFIT()
        {

        }
        public void showClientCredits(string fullname)
        {

        }
        public void showAllCredits(string fullname)
        { 

        }
        public void payCredit (Client cl, decimal money)
        {

        }

    }
}
