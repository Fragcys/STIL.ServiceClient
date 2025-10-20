using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class DomainVaerdierInfoType
{

    private string domainVaerdiIDField;

    private string domainRefField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string domainVaerdiStringField;

    private string domainVaerdiIntegerField;

    private string oplysning1Field;

    private string oplysning2Field;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string DomainVaerdiID
    {
        get => domainVaerdiIDField; set => domainVaerdiIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string DomainRef
    {
        get => domainRefField; set => domainRefField = value;
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
    public string DomainVaerdiString
    {
        get => domainVaerdiStringField; set => domainVaerdiStringField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 5)]
    public string DomainVaerdiInteger
    {
        get => domainVaerdiIntegerField; set => domainVaerdiIntegerField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string Oplysning1
    {
        get => oplysning1Field; set => oplysning1Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string Oplysning2
    {
        get => oplysning2Field; set => oplysning2Field = value;
    }
}
