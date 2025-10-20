namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The personoplysninger tilmelding type class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class personoplysningerTilmeldingType
{
    /// <summary>
    /// The arbejder som field.
    /// </summary>
    private string arbejderSomField;

    /// <summary>
    /// The loen under kursus field.
    /// </summary>
    private enumJN loenUnderKursusField;

    /// <summary>
    /// The loen under kursus field specified.
    /// </summary>
    private bool loenUnderKursusFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="ArbejderSom"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string ArbejderSom
    {
        get => arbejderSomField;
        set => arbejderSomField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="LoenUnderKursus"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public enumJN LoenUnderKursus
    {
        get => loenUnderKursusField;
        set => loenUnderKursusField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="LoenUnderKursusSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnore]
    public bool LoenUnderKursusSpecified
    {
        get => loenUnderKursusFieldSpecified;
        set => loenUnderKursusFieldSpecified = value;
    }
}