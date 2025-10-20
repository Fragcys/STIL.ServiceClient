using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class SpecialeInfoType
{

    private string specialeIDField;

    private string uddannelseRefField;

    private string specialeField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private DateTime lukketForOptagField;

    private bool lukketForOptagFieldSpecified;

    private string dkllField;

    private string eqfField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string SpecialeID
    {
        get => specialeIDField; set => specialeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef
    {
        get => uddannelseRefField; set => uddannelseRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Speciale
    {
        get => specialeField; set => specialeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string KortBetegnelse
    {
        get => kortBetegnelseField; set => kortBetegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 5)]
    public DateTime LukketForOptag
    {
        get => lukketForOptagField; set => lukketForOptagField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool LukketForOptagSpecified
    {
        get => lukketForOptagFieldSpecified; set => lukketForOptagFieldSpecified = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string Dkll
    {
        get => dkllField; set => dkllField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string Eqf
    {
        get => eqfField; set => eqfField = value;
    }
}
