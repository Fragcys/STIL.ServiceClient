using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The modtager type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/commontypes")]
public class ModtagerType
{
    /// <summary>
    /// The modtager system id field.
    /// </summary>
    private string modtagerSystemIdField;

    /// <summary>
    /// The modtager system transaktions id field.
    /// </summary>
    private string modtagerSystemTransaktionsIDField;

    /// <summary>
    /// Gets or sets the <see cref="ModtagerSystemId"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string ModtagerSystemId
    {
        get => modtagerSystemIdField;
        set => modtagerSystemIdField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ModtagerSystemTransaktionsID"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string ModtagerSystemTransaktionsID
    {
        get => modtagerSystemTransaktionsIDField;
        set => modtagerSystemTransaktionsIDField = value;
    }
}