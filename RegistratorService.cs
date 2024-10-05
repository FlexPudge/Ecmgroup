using Ecmgroup.Entity;
using Ecmgroup.FilesWorkerServices;

namespace Ecmgroup
{
    internal class RegistratorService
    {
        private readonly IWorkingWithFiles workingWithFiles;
        private List<Registrator> registratorList = new List<Registrator>();

        public List<Registrator> RegistratorList
        {
            get { return registratorList; }
            private set { registratorList = value; }
        }

        public RegistratorService()
        {
            this.workingWithFiles = new WorkWithXMLFile();
        }

        public void SerializePrimeRegistrators()
        {
            var newRegistrator = new Registrators();
            newRegistrator.Registrator = new List<Registrator>(RegistratorList);
            workingWithFiles.Serialize<Registrators>(newRegistrator, "Registrators.xml");
        }

        //возвращает id регистрата
        public int GetRegistratorID(string registrator)
        {
            SetRegistratorID(registrator);
            int registratorId =
                registratorList.FirstOrDefault(x => x.RegistratorName == registrator).RegistratorID;
            return registratorId;
        }

        //Присваивает id каждому уникальному регистрату
        void SetRegistratorID(string registrator)
        {
            if (registratorList.Count == 0)
            {
                registratorList.Add(new Registrator()
                {
                    RegistratorID = 1,
                    RegistratorName = registrator
                });
            }

            else if (registratorList.FirstOrDefault(x => x.RegistratorName == registrator) == null)
            {
                registratorList.Add(new Registrator()
                {
                    RegistratorID = registratorList.Count + 1,
                    RegistratorName = registrator
                });
            }
        }
    }
}
