namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The tilstededag type class.
/// </summary>
[System.Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilstededag")]
public class tilstededagType
{
    /// <summary>
    /// The dato field.
    /// </summary>
    private System.DateTime datoField;

    /// <summary>
    /// The norm timer field.
    /// </summary>
    private decimal normTimerField;

    /// <summary>
    /// The norm timer field specified.
    /// </summary>
    private bool normTimerFieldSpecified;

    /// <summary>
    /// The timer tilstede field.
    /// </summary>
    private decimal timerTilstedeField;

    /// <summary>
    /// The timer tilstede field specified.
    /// </summary>
    private bool timerTilstedeFieldSpecified;

    /// <summary>
    /// The undervisningssted field.
    /// </summary>
    private undervisningsstedType undervisningsstedField;

    /// <summary>
    /// Gets or sets the <see cref="Dato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 0)]
    public System.DateTime Dato
    {
        get => datoField;
        set => datoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="NormTimer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public decimal NormTimer
    {
        get => normTimerField;
        set => normTimerField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="NormTimerSpecified"/> is set..
    /// </summary>
    [System.Xml.Serialization.XmlIgnore]
    public bool NormTimerSpecified
    {
        get => normTimerFieldSpecified;
        set => normTimerFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TimerTilstede"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public decimal TimerTilstede
    {
        get => timerTilstedeField;
        set => timerTilstedeField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="TimerTilstedeSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnore]
    public bool TimerTilstedeSpecified
    {
        get => timerTilstedeFieldSpecified;
        set => timerTilstedeFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Undervisningssted"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public undervisningsstedType Undervisningssted
    {
        get => undervisningsstedField;
        set => undervisningsstedField = value;
    }
}