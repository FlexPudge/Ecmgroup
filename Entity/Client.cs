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

        private string fIOField;

        private ushort regNumberField;

        private ulong diasoftIDField;

        private bool diasoftIDFieldSpecified;

        private string registratorField;
       
        public string FIO
        {
            get
            {
                return this.fIOField;
            }
            set
            {
                this.fIOField = value;
            }
        }
        
        public ushort RegNumber
        {
            get
            {
                return this.regNumberField;
            }
            set
            {
                this.regNumberField = value;
            }
        }
     
        public ulong DiasoftID
        {
            get
            {
                return this.diasoftIDField;
            }
            set
            {
                this.diasoftIDField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiasoftIDSpecified
        {
            get
            {
                return this.diasoftIDFieldSpecified;
            }
            set
            {
                this.diasoftIDFieldSpecified = value;
            }
        }

        public string Registrator
        {
            get
            {
                return this.registratorField;
            }
            set
            {
                this.registratorField = value;
            }
        }
    }
}
