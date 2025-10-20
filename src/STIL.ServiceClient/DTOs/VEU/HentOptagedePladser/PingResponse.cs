namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// PingResponse.
    /// </summary>
    [System.Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class PingResponse
    {
        /// <summary>
        /// The status field.
        /// </summary>
        private PingResponseStatus statusField;

        /// <summary>
        /// Gets or sets the <see cref="Status"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public PingResponseStatus Status
        {
            get => statusField;
            set => statusField = value;
        }
    }
}