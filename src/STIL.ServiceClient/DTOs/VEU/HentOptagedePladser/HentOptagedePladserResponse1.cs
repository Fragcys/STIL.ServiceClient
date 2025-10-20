namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// HentOptagedePladserResponse1.
    /// </summary>
    [System.Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HentOptagedePladserResponse1 : ResponseType
    {
        /// <summary>
        /// The behandlingstidspunkt field.
        /// </summary>
        private System.DateTime behandlingstidspunktField;

        /// <summary>
        /// The hold liste field.
        /// </summary>
        private HoldListe[] holdListeField;

        /// <summary>
        /// Gets or sets the <see cref="Behandlingstidspunkt"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public System.DateTime Behandlingstidspunkt
        {
            get => behandlingstidspunktField;
            set => behandlingstidspunktField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="HoldListe"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElement("HoldListe", Order = 1)]
        public HoldListe[] HoldListe
        {
            get => holdListeField;
            set => holdListeField = value;
        }
    }
}