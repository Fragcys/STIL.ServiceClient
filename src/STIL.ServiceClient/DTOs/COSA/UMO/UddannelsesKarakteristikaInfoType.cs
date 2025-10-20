using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UddannelsesKarakteristikaInfoType
{

    private string uddannelseKarakIDField;

    private string coesaFormaalRefField;

    private string uddannelsesKarakField;

    private DateTime gyldigFraField;

    private DateTime gyldigTilField;

    private bool gyldigTilFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UddannelseKarakID
    {
        get => uddannelseKarakIDField; set => uddannelseKarakIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string CoesaFormaalRef
    {
        get => coesaFormaalRefField; set => coesaFormaalRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string UddannelsesKarak
    {
        get => uddannelsesKarakField; set => uddannelsesKarakField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime GyldigFra
    {
        get => gyldigFraField; set => gyldigFraField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
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
