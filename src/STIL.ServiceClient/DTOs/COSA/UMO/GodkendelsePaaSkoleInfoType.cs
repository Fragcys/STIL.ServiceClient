using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class GodkendelsePaaSkoleInfoType
{

    private string godkendelsePaaSkoleIDField;

    private string coesaFormaalRefField;

    private string fagRefField;

    private string godkendelsestypeField;

    private string institutionsnummerField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    private string praktikcenterField;

    private string gF1Field;

    private string gF2Field;

    private string hfField;

    private string udlaanInstField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string GodkendelsePaaSkoleID
    {
        get => godkendelsePaaSkoleIDField; set => godkendelsePaaSkoleIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string CoesaFormaalRef
    {
        get => coesaFormaalRefField; set => coesaFormaalRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Godkendelsestype
    {
        get => godkendelsestypeField; set => godkendelsestypeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 4)]
    public string Institutionsnummer
    {
        get => institutionsnummerField; set => institutionsnummerField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 5)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 6)]
    public DateTime Slutdato
    {
        get => slutdatoField; set => slutdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool SlutdatoSpecified
    {
        get => slutdatoFieldSpecified; set => slutdatoFieldSpecified = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string Praktikcenter
    {
        get => praktikcenterField; set => praktikcenterField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string GF1
    {
        get => gF1Field; set => gF1Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string GF2
    {
        get => gF2Field; set => gF2Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string HF
    {
        get => hfField; set => hfField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 11)]
    public string UdlaanInst
    {
        get => udlaanInstField; set => udlaanInstField = value;
    }
}
