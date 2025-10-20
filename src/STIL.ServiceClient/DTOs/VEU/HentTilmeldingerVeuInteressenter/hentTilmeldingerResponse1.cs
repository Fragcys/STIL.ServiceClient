namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hent tilmeldinger response class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(TypeName = "hentTilmeldingerResponse", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class hentTilmeldingerResponse1
{
    /// <summary>
    /// The ws sync res modtager field.
    /// </summary>
    private wsSyncResModtagerV2 wsSyncResModtagerV2Field;

    /// <summary>
    /// The resultat field.
    /// </summary>
    private wsHentTilmeldingerResponse resultatField;

    /// <summary>
    /// Gets or sets the <see cref="wsSyncResModtagerV2"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public wsSyncResModtagerV2 wsSyncResModtagerV2
    {
        get => wsSyncResModtagerV2Field;
        set => wsSyncResModtagerV2Field = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Resultat"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public wsHentTilmeldingerResponse Resultat
    {
        get => resultatField;
        set => resultatField = value;
    }
}