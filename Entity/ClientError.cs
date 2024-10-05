namespace Ecmgroup.Entity
{
    internal class ClientError
    {
        private int countErrorFIO;
        private int countErrorRegNumber;
        private int countErrorDiasoftID;
        private int countErrorRegistrator;
        private int countTotalError;

        public int CountErrorFIO
        {
            get => countErrorFIO;
            set => countErrorFIO = value;
        }
        public int CountErrorRegNumber
        {
            get => countErrorRegNumber;
            set => countErrorRegNumber = value;
        }
        public int CountErrorDiasoftID
        {
            get => countErrorDiasoftID;
            set => countErrorDiasoftID = value;
        }
        public int CountErrorRegistrator
        {
            get => countErrorRegistrator;
            set => countErrorRegistrator = value;
        }

        public int CountTotalError
        {
            get => countTotalError;
            set => countTotalError = value;
        }
    }
}
