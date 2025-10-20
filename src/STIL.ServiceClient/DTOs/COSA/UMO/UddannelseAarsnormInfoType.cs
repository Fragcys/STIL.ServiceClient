using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UddannelseAarsnormInfoType
{
    private string uddannelseAarsnormIDField;
    private string uddannelseRefField;
    private DateTime startdatoField;
    private DateTime slutdatoField;
    private bool slutdatoFieldSpecified;
    private decimal aarsnormKlokketimerField;
    private decimal reguleringsFaktorField;
    private bool reguleringsFaktorFieldSpecified;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UddannelseAarsnormID { get => uddannelseAarsnormIDField; set => uddannelseAarsnormIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef { get => uddannelseRefField; set => uddannelseRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 2)]
    public DateTime Startdato { get => startdatoField; set => startdatoField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime Slutdato { get => slutdatoField; set => slutdatoField = value; }

    [System.Xml.Serialization.XmlIgnore()]
    public bool SlutdatoSpecified { get => slutdatoFieldSpecified; set => slutdatoFieldSpecified = value; }

    [System.Xml.Serialization.XmlElement(Order = 4)]
    public decimal AarsnormKlokketimer { get => aarsnormKlokketimerField; set => aarsnormKlokketimerField = value; }

    [System.Xml.Serialization.XmlElement(Order = 5)]
    public decimal ReguleringsFaktor { get => reguleringsFaktorField; set => reguleringsFaktorField = value; }

    [System.Xml.Serialization.XmlIgnore()]
    public bool ReguleringsFaktorSpecified { get => reguleringsFaktorFieldSpecified; set => reguleringsFaktorFieldSpecified = value; }
}
