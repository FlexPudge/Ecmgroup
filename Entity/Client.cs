namespace Ecmgroup.Entity
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Clients
    {
        private ClientsClient[] clientField;

        [System.Xml.Serialization.XmlElementAttribute("Client")]
        public ClientsClient[] Client
        {
            get
            {
                return this.clientField;
            }
            set
            {
                this.clientField = value;
            }
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ClientsClient
    {
        private int registratorID;

        private string fio;

        private ushort regNumber;

        private ulong diasoftID;

        private bool diasoftIDSpecified;

        private string registrator;

        public int RegistratorID
        {
            get
            {
                return this.registratorID;
            }
            set
            {
                this.registratorID = value;
            }
        }

        public string FIO
        {
            get
            {
                return this.fio;
            }
            set
            {
                this.fio = value;
            }
        }

        public ushort RegNumber
        {
            get
            {
                return this.regNumber;
            }
            set
            {
                this.regNumber = value;
            }
        }

        public ulong DiasoftID
        {
            get
            {
                return this.diasoftID;
            }
            set
            {
                this.diasoftID = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiasoftIDSpecified
        {
            get
            {
                return this.diasoftIDSpecified;
            }
            set
            {
                this.diasoftIDSpecified = value;
            }
        }

        public string Registrator
        {
            get
            {
                return this.registrator;
            }
            set
            {
                this.registrator = value;
            }
        }
    }
}
