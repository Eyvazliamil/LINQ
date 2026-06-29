using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION5 =======");
var sol5 = debtors.Where(x => x.FullName.Length <= 18 && x.Phone.Count((x => x.Equals('7'))) >= 2);
foreach (var debtor in sol5)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
}