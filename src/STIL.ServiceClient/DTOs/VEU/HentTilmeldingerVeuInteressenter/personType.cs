namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The person type class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class personType
{
    /// <summary>
    /// The rnummer field.
    /// </summary>
    private string cPRnummerField;

    /// <summary>
    /// The status cp rnummer field.
    /// </summary>
    private string statusCPRnummerField;

    /// <summary>
    /// The tilmeldings liste field.
    /// </summary>
    private tilmeldingType[] tilmeldingsListeField;

    /// <summary>
    /// Gets or sets the <see cref="CPRnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string CPRnummer
    {
        get => cPRnummerField;
        set => cPRnummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="StatusCPRnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string StatusCPRnummer
    {
        get => statusCPRnummerField;
        set => statusCPRnummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TilmeldingsListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlArray(Order = 2)]
    [System.Xml.Serialization.XmlArrayItem("Tilmelding", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding", IsNullable = false)]
    public tilmeldingType[] TilmeldingsListe
    {
        get => tilmeldingsListeField;
        set => tilmeldingsListeField = value;
    }
}