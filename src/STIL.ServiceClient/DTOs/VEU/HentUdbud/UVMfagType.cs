using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The uv mfag type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class UVMfagType
{
    /// <summary>
    /// The mfag kode field.
    /// </summary>
    private string uVMfagKodeField;

    /// <summary>
    /// The niveau field.
    /// </summary>
    private string niveauField;

    /// <summary>
    /// The betegnelse field.
    /// </summary>
    private string betegnelseField;

    /// <summary>
    /// Gets or sets the <see cref="UVMfagKode"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string UVMfagKode
    {
        get => uVMfagKodeField;
        set => uVMfagKodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Niveau"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Niveau
    {
        get => niveauField;
        set => niveauField = value;
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
}