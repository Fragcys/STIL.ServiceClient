namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hold type class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class holdType
{
    /// <summary>
    /// The betegnelse field.
    /// </summary>
    private string betegnelseField;

    /// <summary>
    /// The kviknummer field.
    /// </summary>
    private string kviknummerField;

    /// <summary>
    /// The uddannelsestype field.
    /// </summary>
    private string uddannelsestypeField;

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kviknummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Kviknummer
    {
        get => kviknummerField;
        set => kviknummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Uddannelsestype"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Uddannelsestype
    {
        get => uddannelsestypeField;
        set => uddannelsestypeField = value;
    }
}