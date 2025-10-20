using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The hold plads type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class holdPladsType
{
    /// <summary>
    /// The dato field.
    /// </summary>
    private DateTime datoField;

    /// <summary>
    /// The antal pladser field.
    /// </summary>
    private decimal antalPladserField;

    /// <summary>
    /// The antal pladser field specified.
    /// </summary>
    private bool antalPladserFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="Dato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 0)]
    public DateTime Dato
    {
        get => datoField;
        set => datoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AntalPladser"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public decimal AntalPladser
    {
        get => antalPladserField;
        set => antalPladserField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="AntalPladserSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnore]
    public bool AntalPladserSpecified
    {
        get => antalPladserFieldSpecified;
        set => antalPladserFieldSpecified = value;
    }
}