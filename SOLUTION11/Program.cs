using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION11 =======");
var sol11 = debtors.Where(x => x.FullName.GroupBy(x => x).Any(g => g.Count() >= 3));
foreach (var debtor in sol11)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}