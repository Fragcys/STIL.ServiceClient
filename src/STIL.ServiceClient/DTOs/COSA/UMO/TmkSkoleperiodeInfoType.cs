using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class TmkSkoleperiodeInfoType
{
    private string tmkSkoleperiodeIDField;
    private string skoleperiodeRefField;
    private string tmkRefField;
    private DateTime startdatoField;
    private DateTime slutdatoField;
    private bool slutdatoFieldSpecified;
    private string coesaFormaalRefField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string TmkSkoleperiodeID { get => tmkSkoleperiodeIDField; set => tmkSkoleperiodeIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string SkoleperiodeRef { get => skoleperiodeRefField; set => skoleperiodeRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string TmkRef { get => tmkRefField; set => tmkRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime Startdato { get => startdatoField; set => startdatoField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime Slutdato { get => slutdatoField; set => slutdatoField = value; }

    [System.Xml.Serialization.XmlIgnore()]
    public bool SlutdatoSpecified { get => slutdatoFieldSpecified; set => slutdatoFieldSpecified = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 5)]
    public string CoesaFormaalRef { get => coesaFormaalRefField; set => coesaFormaalRefField = value; }
}
