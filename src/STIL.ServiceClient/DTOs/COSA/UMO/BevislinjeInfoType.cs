using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class BevislinjeInfoType
{

    private string bevislinjeIDField;

    private string fagRefField;

    private string bevisFormatField;

    private DateTime startdatoField;

    private string bevislinjeNrField;

    private string bevislinjeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string BevislinjeID
    {
        get => bevislinjeIDField; set => bevislinjeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string BevisFormat
    {
        get => bevisFormatField; set => bevisFormatField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 4)]
    public string BevislinjeNr
    {
        get => bevislinjeNrField; set => bevislinjeNrField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string Bevislinje
    {
        get => bevislinjeField; set => bevislinjeField = value;
    }
}
