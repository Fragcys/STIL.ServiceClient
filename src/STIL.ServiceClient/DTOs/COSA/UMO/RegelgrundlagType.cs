using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class RegelgrundlagType
{

    private string regelnrField;

    private DateTime regelDatoField;

    private string regelTypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 0)]
    public string Regelnr
    {
        get => regelnrField; set => regelnrField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 1)]
    public DateTime RegelDato
    {
        get => regelDatoField; set => regelDatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string RegelType
    {
        get => regelTypeField; set => regelTypeField = value;
    }
}
