using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION7 =======");
var sol7 = debtors.Where(x => x.BirthDay.Month == 10 || x.BirthDay.Month == 11 || x.BirthDay.Month == 12);
foreach (var debtor in sol7)
{
    Console.WriteLine((debtor.FullName, debtor.BirthDay.Month, debtor.Debt));
}
