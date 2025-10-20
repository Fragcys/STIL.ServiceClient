using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class TmkInfoType
{

    private string tmkIDField;

    private string kombinationField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string opgoerelsesmetodeField;

    private string indberetFagField;

    private string bidragField;

    private string tmkTypeField;

    private decimal fjernUndervisningsAndelField;

    private bool fjernUndervisningsAndelFieldSpecified;

    private string tmkRefField;

    private string udslusningField;

    private string kombidragField;

    private string driftstilskudField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string TmkID
    {
        get => tmkIDField; set => tmkIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Kombination
    {
        get => kombinationField; set => kombinationField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string KortBetegnelse
    {
        get => kortBetegnelseField; set => kortBetegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Opgoerelsesmetode
    {
        get => opgoerelsesmetodeField; set => opgoerelsesmetodeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string IndberetFag
    {
        get => indberetFagField; set => indberetFagField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string Bidrag
    {
        get => bidragField; set => bidragField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string TmkType
    {
        get => tmkTypeField; set => tmkTypeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public decimal FjernUndervisningsAndel
    {
        get => fjernUndervisningsAndelField; set => fjernUndervisningsAndelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool FjernUndervisningsAndelSpecified
    {
        get => fjernUndervisningsAndelFieldSpecified; set => fjernUndervisningsAndelFieldSpecified = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 9)]
    public string TmkRef
    {
        get => tmkRefField; set => tmkRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string Udslusning
    {
        get => udslusningField; set => udslusningField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 11)]
    public string Kombidrag
    {
        get => kombidragField; set => kombidragField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 12)]
    public string Driftstilskud
    {
        get => driftstilskudField; set => driftstilskudField = value;
    }
}
