using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class StudieretHfOverbygInfoType
{

    private string studieretHfOverbygIDField;

    private string studieretHfOverbygField;

    private string uddannelseRefField;

    private string startaarField;

    private string titelField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string StudieretHfOverbygID
    {
        get => studieretHfOverbygIDField; set => studieretHfOverbygIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string StudieretHfOverbyg
    {
        get => studieretHfOverbygField; set => studieretHfOverbygField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string UddannelseRef
    {
        get => uddannelseRefField; set => uddannelseRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 3)]
    public string Startaar
    {
        get => startaarField; set => startaarField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Titel
    {
        get => titelField; set => titelField = value;
    }
}
