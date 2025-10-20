using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The hent udbud request message class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
public class HentUdbudRequestMessage
{
    /// <summary>
    /// The hent udbud request field.
    /// </summary>
    private HentUdbudRequest1 hentUdbudRequestField;

    /// <summary>
    /// Gets or sets the <see cref="HentUdbudRequest"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud", Order = 0)]
    public HentUdbudRequest1 HentUdbudRequest
    {
        get => hentUdbudRequestField;
        set => hentUdbudRequestField = value;
    }
}