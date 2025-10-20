using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class SkoleperiodeInfoType
{

    private string skoleperiodeIDField;

    private string uddannelseRefField;

    private string specialeRefField;

    private string adgangsvejRefField;

    private string skoleperiodeField;

    private string periodetypeRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string SkoleperiodeID
    {
        get => skoleperiodeIDField; set => skoleperiodeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef
    {
        get => uddannelseRefField; set => uddannelseRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SpecialeRef
    {
        get => specialeRefField; set => specialeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 3)]
    public string AdgangsvejRef
    {
        get => adgangsvejRefField; set => adgangsvejRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Skoleperiode
    {
        get => skoleperiodeField; set => skoleperiodeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 5)]
    public string PeriodetypeRef
    {
        get => periodetypeRefField; set => periodetypeRefField = value;
    }
}
