namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hent tilmeldinger req indhold class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class hentTilmeldingerReqIndhold
{
    /// <summary>
    /// The rnr field.
    /// </summary>
    private string cVRnrField;

    /// <summary>
    /// The rnummer liste field.
    /// </summary>
    private string[] cPRnummerListeField;

    /// <summary>
    /// The fra dato field.
    /// </summary>
    private System.DateTime fraDatoField;

    /// <summary>
    /// The fra dato field specified.
    /// </summary>
    private bool fraDatoFieldSpecified;

    /// <summary>
    /// The til dato field.
    /// </summary>
    private System.DateTime tilDatoField;

    /// <summary>
    /// The til dato field specified.
    /// </summary>
    private bool tilDatoFieldSpecified;

    /// <summary>
    /// The inst nr field.
    /// </summary>
    private string instNrField;

    /// <summary>
    /// Gets or sets the <see cref="CVRnr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string CVRnr
    {
        get => cVRnrField;
        set => cVRnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="CPRnummerListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlArray(Order = 1)]
    [System.Xml.Serialization.XmlArrayItem("CPRnummer", IsNullable = false)]
    public string[] CPRnummerListe
    {
        get => cPRnummerListeField;
        set => cPRnummerListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FraDato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 2)]
    public System.DateTime FraDato
    {
        get => fraDatoField;
        set => fraDatoField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="FraDatoSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnore]
    public bool FraDatoSpecified
    {
        get => fraDatoFieldSpecified;
        set => fraDatoFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TilDato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public System.DateTime TilDato
    {
        get => tilDatoField;
        set => tilDatoField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="TilDatoSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnore]
    public bool TilDatoSpecified
    {
        get => tilDatoFieldSpecified;
        set => tilDatoFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="InstNr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string InstNr
    {
        get => instNrField;
        set => instNrField = value;
    }
}