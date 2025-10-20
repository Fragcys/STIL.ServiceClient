using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The ping response class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
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