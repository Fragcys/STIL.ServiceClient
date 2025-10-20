namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// HentOptagedePladserRequest1.
    /// </summary>
    [System.Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HentOptagedePladserRequest1 : RequestType
    {
        /// <summary>
        /// The akti guid liste field.
        /// </summary>
        private string[] aktiGUIDListeField;

        /// <summary>
        /// Gets or sets the <see cref="AktiGUIDListe"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElement("AktiGUIDListe", Order = 0)]
        public string[] AktiGUIDListe
        {
            get => aktiGUIDListeField;
            set => aktiGUIDListeField = value;
        }
    }
}