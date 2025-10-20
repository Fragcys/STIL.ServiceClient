using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ProeveInfoType
{

    private string proeveIDField;

    private string fagRefField;

    private string proeveKodeField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string karakterskalaRefField;

    private string evalueringsformRefField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    private string skrAntalCensorerField;

    private string skrCentraltStilledeOpgField;

    private string udtraekHeleHoldetField;

    private string proeveafholdelsesformField;

    private string oblVedMangeANiveauFagField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ProeveID
    {
        get => proeveIDField; set => proeveIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string ProeveKode
    {
        get => proeveKodeField; set => proeveKodeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string KortBetegnelse
    {
        get => kortBetegnelseField; set => kortBetegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 5)]
    public string KarakterskalaRef
    {
        get => karakterskalaRefField; set => karakterskalaRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 6)]
    public string EvalueringsformRef
    {
        get => evalueringsformRefField; set => evalueringsformRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 7)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 8)]
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
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 9)]
    public string SkrAntalCensorer
    {
        get => skrAntalCensorerField; set => skrAntalCensorerField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string SkrCentraltStilledeOpg
    {
        get => skrCentraltStilledeOpgField; set => skrCentraltStilledeOpgField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 11)]
    public string UdtraekHeleHoldet
    {
        get => udtraekHeleHoldetField; set => udtraekHeleHoldetField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 12)]
    public string Proeveafholdelsesform
    {
        get => proeveafholdelsesformField; set => proeveafholdelsesformField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 13)]
    public string OblVedMangeANiveauFag
    {
        get => oblVedMangeANiveauFagField; set => oblVedMangeANiveauFagField = value;
    }
}
