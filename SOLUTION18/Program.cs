using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION18 =======");
var sol18 = debtors.Where(x => x.Phone.Distinct().Count() == x.Phone.Length);
foreach (var debtor in sol18)
{
    Console.WriteLine((debtor.FullName, debtor.Phone, debtor.Debt));
}