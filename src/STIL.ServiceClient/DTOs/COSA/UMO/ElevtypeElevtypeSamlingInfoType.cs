using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ElevtypeElevtypeSamlingInfoType
{

    private string elevtypeElevtypeSamlingIDField;

    private string elevtypeSamlingRefField;

    private string elevtypeRefField;

    private DateTime gyldigFraField;

    private DateTime gyldigTilField;

    private bool gyldigTilFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ElevtypeElevtypeSamlingID
    {
        get => elevtypeElevtypeSamlingIDField; set => elevtypeElevtypeSamlingIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string ElevtypeSamlingRef
    {
        get => elevtypeSamlingRefField; set => elevtypeSamlingRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string ElevtypeRef
    {
        get => elevtypeRefField; set => elevtypeRefField = value;
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
