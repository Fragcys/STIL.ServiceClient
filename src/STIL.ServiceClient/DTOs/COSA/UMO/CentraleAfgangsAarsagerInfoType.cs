using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class CentraleAfgangsAarsagerInfoType
{

    private string centralAfgangsAarsagIDField;

    private string afgangsAarsagField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string gennemfoertField;

    private string kvalificeretTilHovedforloebField;

    private string eASYPIndberetField;

    private string ungeDatabaseIndberetField;

    private string ledelsesinformationField;

    private string tvungenPerspektivField;

    private string ungeDatabaseAfgangsAarsagField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string CentralAfgangsAarsagID
    {
        get => centralAfgangsAarsagIDField; set => centralAfgangsAarsagIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string AfgangsAarsag
    {
        get => afgangsAarsagField; set => afgangsAarsagField = value;
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
    public string Gennemfoert
    {
        get => gennemfoertField; set => gennemfoertField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string KvalificeretTilHovedforloeb
    {
        get => kvalificeretTilHovedforloebField; set => kvalificeretTilHovedforloebField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string EASYPIndberet
    {
        get => eASYPIndberetField; set => eASYPIndberetField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string UngeDatabaseIndberet
    {
        get => ungeDatabaseIndberetField; set => ungeDatabaseIndberetField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string Ledelsesinformation
    {
        get => ledelsesinformationField; set => ledelsesinformationField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string TvungenPerspektiv
    {
        get => tvungenPerspektivField; set => tvungenPerspektivField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string UngeDatabaseAfgangsAarsag
    {
        get => ungeDatabaseAfgangsAarsagField; set => ungeDatabaseAfgangsAarsagField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 11)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 12)]
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
}
