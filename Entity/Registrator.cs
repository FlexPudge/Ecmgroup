namespace Ecmgroup.Entity
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Registrators
    {
        private List<Registrator> registrator;

        [System.Xml.Serialization.XmlElementAttribute("Registrator")]
        public List<Registrator> Registrator
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

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Registrator
    {
        #region private pror
        private int registratorID;
        private string registratorName;

        #endregion

        #region public prop
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

        public string RegistratorName
        {
            get
            {
                return this.registratorName;
            }
            set
            {
                this.registratorName = value;
            }
        }
        #endregion
    }
}
