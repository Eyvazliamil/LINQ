using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION16 =======");
var sol16 = debtors.Where(x => (x.BirthDay.Year) <= 1945);
foreach (var debtor in sol16)
{
    Console.WriteLine((debtor.FullName, debtor.BirthDay.Year, debtor.Debt));
}