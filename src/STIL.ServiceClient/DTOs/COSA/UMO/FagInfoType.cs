using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagInfoType
{

    private string fagIDField;

    private FagType fagField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private DateTime startdatoField;

    private bool startdatoFieldSpecified;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    private string fagkategoriRefField;

    private string kravDbFagRefField;

    private string censorIndberetningField;

    private string eudProevefagField;

    private decimal ectsPointField;

    private bool ectsPointFieldSpecified;

    private string dkllField;

    private string eqfField;

    private string overskrivVarighedField;

    private decimal varighedDageField;

    private bool varighedDageFieldSpecified;

    private decimal varighedTimerField;

    private bool varighedTimerFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagID
    {
        get => fagIDField; set => fagIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public FagType Fag
    {
        get => fagField; set => fagField = value;
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
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool StartdatoSpecified
    {
        get => startdatoFieldSpecified; set => startdatoFieldSpecified = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 5)]
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
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 6)]
    public string FagkategoriRef
    {
        get => fagkategoriRefField; set => fagkategoriRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 7)]
    public string KravDbFagRef
    {
        get => kravDbFagRefField; set => kravDbFagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string CensorIndberetning
    {
        get => censorIndberetningField; set => censorIndberetningField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string EudProevefag
    {
        get => eudProevefagField; set => eudProevefagField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public decimal EctsPoint
    {
        get => ectsPointField; set => ectsPointField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool EctsPointSpecified
    {
        get => ectsPointFieldSpecified; set => ectsPointFieldSpecified = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 11)]
    public string Dkll
    {
        get => dkllField; set => dkllField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 12)]
    public string Eqf
    {
        get => eqfField; set => eqfField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 13)]
    public string OverskrivVarighed
    {
        get => overskrivVarighedField; set => overskrivVarighedField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 14)]
    public decimal VarighedDage
    {
        get => varighedDageField; set => varighedDageField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool VarighedDageSpecified
    {
        get => varighedDageFieldSpecified; set => varighedDageFieldSpecified = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 15)]
    public decimal VarighedTimer
    {
        get => varighedTimerField; set => varighedTimerField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool VarighedTimerSpecified
    {
        get => varighedTimerFieldSpecified; set => varighedTimerFieldSpecified = value;
    }
}
