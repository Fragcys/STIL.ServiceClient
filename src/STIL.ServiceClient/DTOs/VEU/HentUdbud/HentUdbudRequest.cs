using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The hent udbud request class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
public class HentUdbudRequest
{
    /// <summary>
    /// The identifier field.
    /// </summary>
    private Identifier identifierField;

    /// <summary>
    /// The message field.
    /// </summary>
    private HentUdbudRequestMessage messageField;

    /// <summary>
    /// Gets or sets the <see cref="Identifier"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public Identifier Identifier
    {
        get => identifierField;
        set => identifierField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Message"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public HentUdbudRequestMessage Message
    {
        get => messageField;
        set => messageField = value;
    }
}