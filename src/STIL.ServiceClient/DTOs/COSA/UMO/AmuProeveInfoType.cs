using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class AmuProeveInfoType
{

    private string amuProeveIDField;

    private string amuMaalRefField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    private string skriftligProveField;

    private string mundtligProveField;

    private string praktiskProveField;

    private string proveSelvstudField;

    private string andetTekstField;

    private string proveFjernundField;

    private string beskrivelseTekstField;

    private string bedomGrundlagTekstField;

    private string bedomKritTekstField;

    private string dispLavAktivitetField;

    private string dispSaerligeOmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string AmuProeveID
    {
        get => amuProeveIDField; set => amuProeveIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string AmuMaalRef
    {
        get => amuMaalRefField; set => amuMaalRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 2)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
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
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string SkriftligProve
    {
        get => skriftligProveField; set => skriftligProveField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string MundtligProve
    {
        get => mundtligProveField; set => mundtligProveField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string PraktiskProve
    {
        get => praktiskProveField; set => praktiskProveField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string ProveSelvstud
    {
        get => proveSelvstudField; set => proveSelvstudField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string AndetTekst
    {
        get => andetTekstField; set => andetTekstField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string ProveFjernund
    {
        get => proveFjernundField; set => proveFjernundField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string BeskrivelseTekst
    {
        get => beskrivelseTekstField; set => beskrivelseTekstField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 11)]
    public string BedomGrundlagTekst
    {
        get => bedomGrundlagTekstField; set => bedomGrundlagTekstField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 12)]
    public string BedomKritTekst
    {
        get => bedomKritTekstField; set => bedomKritTekstField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 13)]
    public string DispLavAktivitet
    {
        get => dispLavAktivitetField; set => dispLavAktivitetField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 14)]
    public string DispSaerligeOm
    {
        get => dispSaerligeOmField; set => dispSaerligeOmField = value;
    }
}
