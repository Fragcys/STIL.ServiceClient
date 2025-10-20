using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class KarakterVaerdiInfoType
{

    private string karakterVaerdiIDField;

    private string karakterVaerdiField;

    private string karakterskalaRefField;

    private string betegnelseField;

    private int sekvensField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string KarakterVaerdiID
    {
        get => karakterVaerdiIDField; set => karakterVaerdiIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string KarakterVaerdi
    {
        get => karakterVaerdiField; set => karakterVaerdiField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string KarakterskalaRef
    {
        get => karakterskalaRefField; set => karakterskalaRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public int Sekvens
    {
        get => sekvensField; set => sekvensField = value;
    }
}
