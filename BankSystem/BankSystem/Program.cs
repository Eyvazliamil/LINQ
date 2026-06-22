using BankSystem.CEOFolder;
using BankSystem.CLIENTFolder;
using BankSystem.MANAGERFolder;
using BankSystem.WORKERFolder;


#region
List<Worker> workers = new List<Worker>();
List<Manager> managers = new List<Manager>();
List<Client> clients = new List<Client>();

Ceo ceo = new Ceo(Guid.NewGuid(), "Mehemmed", "Memmedli", 41, "Ceo of Business", 15000m);

managers.Add(new Manager(Guid.NewGuid(), "Bob", "Trump", 39, "IT Project Management", 1200m));
managers.Add(new Manager(Guid.NewGuid(), "Alex", "Gray", 24, "Infrastructure Manager", 900m));

workers.Add(new Worker(Guid.NewGuid(), "John", "Smith", 28, "Developer", 800m, "9:00", "18:00"));
workers.Add(new Worker(Guid.NewGuid(), "Sara", "Lee", 31, "Designer", 750m, "10:00", "19:00"));
workers.Add(new Worker(Guid.NewGuid(), "Mike", "Brown", 25, "Tester", 700m, "8:00", "17:00"));

clients.Add(new Client(Guid.NewGuid(), "Emily", "Clark", 35, "123 Main St", "456 Office Ave", 5000m));
clients.Add(new Client(Guid.NewGuid(), "James", "White", 42, "789 Elm St", "321 Business Rd", 12000m));
clients.Add(new Client(Guid.NewGuid(), "Anna", "Black", 29, "55 Park Lane", "88 Corp Blvd", 8500m));
#endregion

#region
Console.WriteLine("-------------------- CEO --------------------");
Console.WriteLine(ceo);
Console.WriteLine("=======================================================");

Console.WriteLine("-------------------- MANAGERS --------------------");
foreach (var manage in managers)
    Console.WriteLine(manage);

Console.WriteLine("=======================================================");

Console.WriteLine("-------------------- WORKERS --------------------");
foreach (var worker in workers)
    Console.WriteLine(worker);

Console.WriteLine("=======================================================");

Console.WriteLine("-------------------- CLIENTS --------------------");
foreach (var client in clients)
    Console.WriteLine(client);
#endregion

#region
ceo.makeMeeting();
ceo.control();
ceo.decreasePercentage();
#endregion