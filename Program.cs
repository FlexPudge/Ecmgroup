using Ecmgroup;


RegistratorService registratorService = new RegistratorService();
ErrorService errorService = new ErrorService();
ClientService clientService = new ClientService(registratorService, errorService);

string pathToFiles = @"C:\Users\Misha\Desktop\Clients.xml";
var clients = clientService.DeserializeClients(pathToFiles);
var primeClients = clientService.GetPrimeList(clients);

registratorService.SerializePrimeRegistrators();
clientService.SerializePrimeClients(primeClients);
errorService.SaveErrorText();

Console.ReadKey();