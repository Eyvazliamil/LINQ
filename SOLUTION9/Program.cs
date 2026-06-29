using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION9 =======");
var sol9 = debtors.Where(x => !x.Phone.Contains('8'));
foreach (var debtor in sol9)
{
    Console.WriteLine((debtor.FullName, debtor.Phone, debtor.Debt));
}