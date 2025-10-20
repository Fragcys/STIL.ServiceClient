namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// FagPladsType.
    /// </summary>
    [System.Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class FagPladsType
    {
        /// <summary>
        /// The dato field.
        /// </summary>
        private System.DateTime datoField;

        /// <summary>
        /// The optaget antal pladser field.
        /// </summary>
        private decimal optagetAntalPladserField;

        /// <summary>
        /// Gets or sets the <see cref="Dato"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElement(DataType = "date", Order = 0)]
        public System.DateTime Dato
        {
            get => datoField;
            set => datoField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="OptagetAntalPladser"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public decimal OptagetAntalPladser
        {
            get => optagetAntalPladserField;
            set => optagetAntalPladserField = value;
        }
    }
}