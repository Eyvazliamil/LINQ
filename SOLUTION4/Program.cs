using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION4 =======");
var sol4 = debtors.Where(x => x.Debt <= 5000);
foreach (var debtor in sol4)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}