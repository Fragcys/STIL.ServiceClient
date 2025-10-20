using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The skolefag uddannelse type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skolefagUddannelseType
{
    /// <summary>
    /// The os aformal field.
    /// </summary>
    private string cOSAformalField;

    /// <summary>
    /// The version field.
    /// </summary>
    private string versionField;

    /// <summary>
    /// The betegnelse field.
    /// </summary>
    private string betegnelseField;

    /// <summary>
    /// The uddannelsestype field.
    /// </summary>
    private UddannelsestypeType uddannelsestypeField;

    /// <summary>
    /// The uddannelsestype field specified.
    /// </summary>
    private bool uddannelsestypeFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="COSAformal"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string COSAformal
    {
        get => cOSAformalField;
        set => cOSAformalField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Version"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Version
    {
        get => versionField;
        set => versionField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Uddannelsestype"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public UddannelsestypeType Uddannelsestype
    {
        get => uddannelsestypeField;
        set => uddannelsestypeField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="UddannelsestypeSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnore]
    public bool UddannelsestypeSpecified
    {
        get => uddannelsestypeFieldSpecified;
        set => uddannelsestypeFieldSpecified = value;
    }
}