using Ecmgroup.Entity;
using Ecmgroup.FilesWorkerServices;

var pathToFiles = @"C:\Users\Misha\Desktop\Clients.xml";
var clients = WorkWithFiles.Deserialize<Clients>(pathToFiles);

Console.ReadKey();