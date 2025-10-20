namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// ResponseType.
    /// </summary>
    [System.Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/commontypes")]
    public abstract class ResponseType
    {
        /// <summary>
        /// The modtager field.
        /// </summary>
        private ModtagerType modtagerField;

        /// <summary>
        /// Gets or sets the <see cref="Modtager"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ModtagerType Modtager
        {
            get => modtagerField;
            set => modtagerField = value;
        }
    }
}