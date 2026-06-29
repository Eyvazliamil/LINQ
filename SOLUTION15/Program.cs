using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;


Console.WriteLine("======= SOLUTION15 =======");
var sol15 = debtors.Sum(x => x.Debt) / debtors.Count();
Console.WriteLine(sol15);