using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;

Console.WriteLine("======= SOLUTION3 =======");
var sol3 = debtors.Where(x => (2026 - x.BirthDay.Year) >= 26 && (2026 - x.BirthDay.Year) <= 36);
foreach (var debtor in sol3)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}