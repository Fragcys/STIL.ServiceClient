using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class BtypeTtypeTmerkeInfoType
{

    private string btypeTtypeTmerkeIDField;

    private string beregningstypeRefField;

    private string taksttypeRefField;

    private string tilskudsmaerkeRefField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string BtypeTtypeTmerkeID
    {
        get => btypeTtypeTmerkeIDField; set => btypeTtypeTmerkeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string BeregningstypeRef
    {
        get => beregningstypeRefField; set => beregningstypeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string TaksttypeRef
    {
        get => taksttypeRefField; set => taksttypeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 3)]
    public string TilskudsmaerkeRef
    {
        get => tilskudsmaerkeRefField; set => tilskudsmaerkeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
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
}
