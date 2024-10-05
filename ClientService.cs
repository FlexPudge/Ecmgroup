using Ecmgroup.Entity;
using Ecmgroup.FilesWorkerServices;

namespace Ecmgroup
{
    internal class ClientService
    {
        private readonly IWorkingWithFiles workingWithFiles;
        private readonly RegistratorService registratorService;
        private readonly ErrorService errorService;
        public ClientService(RegistratorService registratorService,
            ErrorService errorService)
        {
            workingWithFiles = new WorkWithXMLFile();
            this.errorService = errorService;
            this.registratorService = registratorService;
        }

        //получение готового отвалидированного списка клиентов
        public IList<Client> GetPrimeList(IList<Client> clients)
        {
            var primeClients = new List<Client>();

            foreach (var client in clients)
            {
                if (IsPrime(client))
                {
                    primeClients.Add(client);
                }
            }
            return primeClients.ToList();
        }

        public void SerializePrimeClients(IList<Client> clients)
        {
            var newClients = new Clients();
            newClients.Client = new List<Client>(clients);
            workingWithFiles.Serialize<Clients>(newClients, "Clients.xml");
        }

        public IList<Client> DeserializeClients(string path)
        {
            return workingWithFiles.Deserialize<Clients>(path).Client;
        }

        //Валидация записи о клиенте
        bool IsPrime(Client client)
        {
            if (client.FIO == string.Empty ||
                client.RegNumber == 0 ||
                client.DiasoftID == 0 ||
                client.Registrator == string.Empty)
            {
                errorService.RecordingError(client);
                return false;
            }

            else
            {
                client.RegistratorID = registratorService.
                    GetRegistratorID(client.Registrator);
                return true;
            }
        }
    }
}
