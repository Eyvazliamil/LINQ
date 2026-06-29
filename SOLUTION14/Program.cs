using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION14 =======");
var sol14 = debtors.OrderByDescending(x => x.Debt).Take(5);
foreach (var debtor in sol14)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}