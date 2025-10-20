using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class TaksttypeInfoType
{

    private string taksttypeIDField;

    private string taksttypeField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string varighedsuafhengigField;

    private string skoleField;

    private string fjernField;

    private string virkField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string TaksttypeID
    {
        get => taksttypeIDField; set => taksttypeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Taksttype
    {
        get => taksttypeField; set => taksttypeField = value;
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
    public string Varighedsuafhengig
    {
        get => varighedsuafhengigField; set => varighedsuafhengigField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string Skole
    {
        get => skoleField; set => skoleField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string Fjern
    {
        get => fjernField; set => fjernField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string Virk
    {
        get => virkField; set => virkField = value;
    }
}
