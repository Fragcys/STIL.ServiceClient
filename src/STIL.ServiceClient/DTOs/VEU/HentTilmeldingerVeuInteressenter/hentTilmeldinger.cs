namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hent tilmeldinger class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class hentTilmeldinger
{
    /// <summary>
    /// The ws sync req modtager field.
    /// </summary>
    private wsSyncReqModtagerV2 wsSyncReqModtagerV2Field;

    /// <summary>
    /// The besked field.
    /// </summary>
    private hentTilmeldingerRequest beskedField;

    /// <summary>
    /// Gets or sets the <see cref="wsSyncReqModtagerV2"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public wsSyncReqModtagerV2 wsSyncReqModtagerV2
    {
        get => wsSyncReqModtagerV2Field;
        set => wsSyncReqModtagerV2Field = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Besked"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public hentTilmeldingerRequest Besked
    {
        get => beskedField;
        set => beskedField = value;
    }
}