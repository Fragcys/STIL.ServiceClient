using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UddannelseInfoType
{

    private string uddannelseIDField;

    private string coesaFormaalRefField;

    private string uddannelseVersionField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string uddaTypeField;

    private DateTime lukketForOptagField;

    private bool lukketForOptagFieldSpecified;

    private string elevplanUddannelseField;

    private string taksonomiRefField;

    private string bevisTilEksamensDBField;

    private string dkllField;

    private string eqfField;

    private string elevtypeJaNejField;

    private string gF1Field;

    private string gF2Field;

    private string hfField;

    private string statistikIndberetningField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UddannelseID
    {
        get => uddannelseIDField; set => uddannelseIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string CoesaFormaalRef
    {
        get => coesaFormaalRefField; set => coesaFormaalRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 2)]
    public string UddannelseVersion
    {
        get => uddannelseVersionField; set => uddannelseVersionField = value;
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
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string UddaType
    {
        get => uddaTypeField; set => uddaTypeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 6)]
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
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string ElevplanUddannelse
    {
        get => elevplanUddannelseField; set => elevplanUddannelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 8)]
    public string TaksonomiRef
    {
        get => taksonomiRefField; set => taksonomiRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string BevisTilEksamensDB
    {
        get => bevisTilEksamensDBField; set => bevisTilEksamensDBField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string Dkll
    {
        get => dkllField; set => dkllField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 11)]
    public string Eqf
    {
        get => eqfField; set => eqfField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 12)]
    public string ElevtypeJaNej
    {
        get => elevtypeJaNejField; set => elevtypeJaNejField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 13)]
    public string GF1
    {
        get => gF1Field; set => gF1Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 14)]
    public string GF2
    {
        get => gF2Field; set => gF2Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 15)]
    public string HF
    {
        get => hfField; set => hfField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 16)]
    public string StatistikIndberetning
    {
        get => statistikIndberetningField; set => statistikIndberetningField = value;
    }
}
