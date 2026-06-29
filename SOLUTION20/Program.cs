using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION20 =======");
var sol20 = debtors.Where(x => x.FullName.Contains('s') && x.FullName.Contains('m') && x.FullName.Contains('i') && x.FullName.Contains('l') && x.FullName.Contains('e'));
foreach (var debtor in sol20)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}