using Ecmgroup.Entity;
using Ecmgroup.FilesWorkerServices;

namespace Ecmgroup
{
    internal class ErrorService
    {
        private readonly WorkingWithTXTFiles workingWithFiles;
        private ClientError clientErrors;

        public ClientError ClientErrors
        {
            get => clientErrors ??= new ClientError();
            private set => clientErrors = value;
        }

        public ErrorService()
        {
            workingWithFiles = new WorkingWithTXTFiles();
        }

        public void RecordingError(Client client)
        {
            if (client.FIO == string.Empty)
                ClientErrors.CountErrorFIO++;

            if (client.RegNumber == 0)
                ClientErrors.CountErrorRegNumber++;

            if (client.DiasoftID == 0)
                ClientErrors.CountErrorDiasoftID++;

            if (client.Registrator == string.Empty)
                ClientErrors.CountErrorRegistrator++;

            ClientErrors.CountTotalError++;
        }

        public void SaveErrorText()
        {
            var errorMessage = $"Не указан DiasoftID: {ClientErrors.CountErrorDiasoftID} записей\r\n" +
                $"Не указан Регистратор: {ClientErrors.CountErrorRegNumber} записей\r\n" +
                $"Не указано ФИО: {ClientErrors.CountErrorFIO} записей \r\n" +
                $"Всего ошибочных записей: {ClientErrors.CountTotalError}\r\n";
            workingWithFiles.Serialize(errorMessage,"ClientError.txt");
        }
    }
}
