namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The skolefag type class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/skolefagHoldplacering")]
public class skolefagType
{
    /// <summary>
    /// The skolefagskode field.
    /// </summary>
    private string skolefagskodeField;

    /// <summary>
    /// The niveau field.
    /// </summary>
    private string niveauField;

    /// <summary>
    /// The betegnelse field.
    /// </summary>
    private string betegnelseField;

    /// <summary>
    /// Gets or sets the <see cref="Skolefagskode"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string Skolefagskode
    {
        get => skolefagskodeField;
        set => skolefagskodeField = value;
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