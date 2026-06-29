using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION8 =======");
var sol8 = debtors.Where(x => x.Debt > debtors.Average(x => x.Debt))
    .OrderByDescending(x => x.FullName)
    .OrderByDescending(x => x.Debt);
foreach (var debtor in sol8)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}