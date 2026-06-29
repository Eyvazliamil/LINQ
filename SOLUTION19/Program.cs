using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION19 =======");
var sol19 = debtors.Where(x => ((x.Debt - 500 * (x.BirthDay.Month)) == 0));
foreach (var debtor in sol19)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}
