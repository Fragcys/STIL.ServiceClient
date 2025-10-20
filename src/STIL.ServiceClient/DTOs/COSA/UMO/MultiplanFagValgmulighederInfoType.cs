using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class MultiplanFagValgmulighederInfoType
{

    private string valgmulighedIDField;

    private string multiplanFagRefField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    private string sorteringField;

    private string valgmulighedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ValgmulighedID
    {
        get => valgmulighedIDField; set => valgmulighedIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string MultiplanFagRef
    {
        get => multiplanFagRefField; set => multiplanFagRefField = value;
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
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 4)]
    public string Sortering
    {
        get => sorteringField; set => sorteringField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string Valgmulighed
    {
        get => valgmulighedField; set => valgmulighedField = value;
    }
}
