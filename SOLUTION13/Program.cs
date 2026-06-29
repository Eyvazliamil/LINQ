using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION13 =======");
var yearMostRepeated = debtors.GroupBy(x => x.BirthDay.Year)
    .OrderByDescending(x => x.Count())
    .First().Key;

var sol13 = debtors.Where(x => (x.BirthDay.Year) == yearMostRepeated);
foreach (var debtor in sol13)
{
    Console.WriteLine((debtor.FullName, debtor.BirthDay.Year, debtor.Debt));
}