using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;

Console.WriteLine("======= SOLUTION2 =======");
var sol2 = debtors.Where(x => x.Email.Contains("@rhyta.com") || x.Email.Contains("@dayrep.com"));
foreach (var debtor in sol2)
{
    Console.WriteLine(debtor.FullName);
}