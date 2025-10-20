namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The ws sync res modtager class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/common")]
public class wsSyncResModtagerV2
{
    /// <summary>
    /// The modtager system id field.
    /// </summary>
    private string modtagerSystemIDField;

    /// <summary>
    /// The modtager system transaktions id field.
    /// </summary>
    private string modtagerSystemTransaktionsIDField;

    /// <summary>
    /// Gets or sets the <see cref="ModtagerSystemID"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string ModtagerSystemID
    {
        get => modtagerSystemIDField;
        set => modtagerSystemIDField = value;
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