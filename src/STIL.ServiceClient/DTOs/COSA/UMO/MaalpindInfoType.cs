using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class MaalpindInfoType
{

    private string maalpindIDField;

    private string fagRefField;

    private string maalpindField;

    private string tekstField;

    private DateTime gyldigFraField;

    private DateTime gyldigTilField;

    private bool gyldigTilFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string MaalpindID
    {
        get => maalpindIDField; set => maalpindIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 2)]
    public string Maalpind
    {
        get => maalpindField; set => maalpindField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Tekst
    {
        get => tekstField; set => tekstField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime GyldigFra
    {
        get => gyldigFraField; set => gyldigFraField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 5)]
    public DateTime GyldigTil
    {
        get => gyldigTilField; set => gyldigTilField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool GyldigTilSpecified
    {
        get => gyldigTilFieldSpecified; set => gyldigTilFieldSpecified = value;
    }
}
