using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class PeriodetypeInfoType
{

    private string periodetypeIDField;

    private string periodetypeField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string overlapTilladtSkoleforloebField;

    private string aUBRefusionField;

    private string overlapTilladtSkolepraktikField;

    private string gF1Field;

    private string gF2Field;

    private string hfField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string PeriodetypeID
    {
        get => periodetypeIDField; set => periodetypeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Periodetype
    {
        get => periodetypeField; set => periodetypeField = value;
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
    public string OverlapTilladtSkoleforloeb
    {
        get => overlapTilladtSkoleforloebField; set => overlapTilladtSkoleforloebField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string AUBRefusion
    {
        get => aUBRefusionField; set => aUBRefusionField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string OverlapTilladtSkolepraktik
    {
        get => overlapTilladtSkolepraktikField; set => overlapTilladtSkolepraktikField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string GF1
    {
        get => gF1Field; set => gF1Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string GF2
    {
        get => gF2Field; set => gF2Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string HF
    {
        get => hfField; set => hfField = value;
    }
}
