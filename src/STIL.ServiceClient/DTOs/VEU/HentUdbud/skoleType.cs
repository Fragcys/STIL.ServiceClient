using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The skole type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skoleType
{
    /// <summary>
    /// The dsnr field.
    /// </summary>
    private string dsnrField;

    /// <summary>
    /// The navn field.
    /// </summary>
    private string navnField;

    /// <summary>
    /// Gets or sets the <see cref="Dsnr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string Dsnr
    {
        get => dsnrField;
        set => dsnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Navn"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Navn
    {
        get => navnField;
        set => navnField = value;
    }
}