using BankSystem.BANKFolder;
using BankSystem.CEOFolder;
using BankSystem.CLIENTFolder;
using BankSystem.CREDITFolder;
using BankSystem.MANAGERFolder;
using BankSystem.OPERATIONFolder;
using BankSystem.WORKERFolder;

#region
List<Worker> workers = new List<Worker>();
List<Manager> managers = new List<Manager>();
List<Client> clients = new List<Client>();
List<Credit> credits = new List<Credit>();
List<Bank> banks = new List<Bank>();

var ceo1 = new Ceo(Guid.NewGuid(), "Mehemmed", "Memmedli", 41, "Ceo of Business", 15000m);

banks.Add(new Bank("ABB", 150000m, 200000m, ceo1));

managers.Add(new Manager(Guid.NewGuid(), "Bob", "Trump", 39, "IT Project Management", 1200m));
managers.Add(new Manager(Guid.NewGuid(), "Alex", "Gray", 24, "Infrastructure Manager", 900m));

workers.Add(new Worker(Guid.NewGuid(), "John", "Smith", 28, "Developer", 800m, "9:00", "18:00"));
workers.Add(new Worker(Guid.NewGuid(), "Sara", "Lee", 31, "Designer", 750m, "10:00", "19:00"));
workers.Add(new Worker(Guid.NewGuid(), "Mike", "Brown", 25, "Tester", 700m, "8:00", "17:00"));

var emily = new Client(Guid.NewGuid(), "Emily", "Clark", 35, "123 Main St", "456 Office Ave", 5000m);
var stefan = new Client(Guid.NewGuid(), "Stefan", "Tuper", 19, "23 DownCity", "456 Office Ave", 3000m);
clients.Add(emily);
clients.Add(stefan);
clients.Add(new Client(Guid.NewGuid(), "James", "White", 42, "789 Elm St", "321 Business Rd", 12000m));
clients.Add(new Client(Guid.NewGuid(), "Anna", "Black", 29, "55 Park Lane", "88 Corp Blvd", 8500m));

credits.Add(new Credit(Guid.NewGuid(), emily, 100m, 10m, 5));
credits.Add(new Credit(Guid.NewGuid(), stefan, 400m, 6.5m, 12));
#endregion

#region
//Console.WriteLine("-------------------- BANKS --------------------");
//foreach (var bank in banks)
//    Console.WriteLine(bank);

//Console.WriteLine("-------------------- CEO --------------------");
//Console.WriteLine(ceo1);
//Console.WriteLine("=======================================================");

//Console.WriteLine("-------------------- MANAGERS --------------------");
//foreach (var manage in managers)
//    Console.WriteLine(manage);

//Console.WriteLine("=======================================================");

//Console.WriteLine("-------------------- WORKERS --------------------");
//foreach (var worker in workers)
//    Console.WriteLine(worker);

//Console.WriteLine("=======================================================");

//Console.WriteLine("-------------------- CLIENTS --------------------");
//foreach (var client in clients)
//    Console.WriteLine(client);

//Console.WriteLine("=======================================================");

//Console.WriteLine("-------------------- CREDITS --------------------");
//foreach (var credit in credits)
//{
//    Console.WriteLine(credit);
//    Console.WriteLine("============== CALCULATE PERCENT ==============");
//    Console.WriteLine($"Calculate Percent: {credit.CalculatePercent()}");
//    Console.WriteLine($"Payment --------------------- "); credit.Payment();
//}
#endregion

#region
//Console.WriteLine("\n"); ; ceo1.makeMeeting(ceo1._Name + " " + ceo1._Surname);
//ceo1.control(ceo1._Name + " " + ceo1._Surname);
//ceo1.decreasePercentage(ceo1._Name + " " + ceo1._Surname);
#endregion

#region
//Console.WriteLine("========= Show Client Credits =========");
//foreach (var credit in credits) {
//    banks[0].showClientCredits(credit); Console.WriteLine("-----------------------------");
//}


//Console.WriteLine("========= CALCULATE PROFIT =========");
//foreach (var credit in credits)
//    banks[0].Credits.Add(credit);

//banks[0].CALCULATE_PROFIT();


//Console.WriteLine("========= Pay Credit =========");
//foreach (var credit in credits)
//    banks[0].payCredit(credit, credit._Client._Salary);
#endregion


//var op1 = new Operation(Guid.NewGuid(), "Credit Operation 1", DateTime.Now);
//var op2 = new Operation(Guid.NewGuid(), "Credit Operation 2", DateTime.Now);
//var op3 = new Operation(Guid.NewGuid(), "Credit Operation 3", DateTime.Now);

//workers[0].AddOperation(new Operation(Guid.NewGuid(), "Credit Operation 1", DateTime.Now));
//workers[1].AddOperation(new Operation(Guid.NewGuid(), "Credit Operation 2", DateTime.Now));
//workers[2].AddOperation(new Operation(Guid.NewGuid(), "Credit Operation 3", DateTime.Now));