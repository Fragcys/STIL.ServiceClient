using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class CoesaFormaalInfoType
{

    private string coesaFormaalIDField;

    private string coesaFormaalField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    private string formaalsgruppeRefField;

    private string udvalgRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string CoesaFormaalID
    {
        get => coesaFormaalIDField; set => coesaFormaalIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string CoesaFormaal
    {
        get => coesaFormaalField; set => coesaFormaalField = value;
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
    public string FormaalsgruppeRef
    {
        get => formaalsgruppeRefField; set => formaalsgruppeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 7)]
    public string UdvalgRef
    {
        get => udvalgRefField; set => udvalgRefField = value;
    }
}
