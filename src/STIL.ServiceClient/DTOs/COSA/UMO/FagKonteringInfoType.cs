using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagKonteringInfoType
{

    private string fagKonteringIDField;

    private string fagRefField;

    private string finansaarField;

    private string coesaFormalRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagKonteringID
    {
        get => fagKonteringIDField; set => fagKonteringIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 2)]
    public string Finansaar
    {
        get => finansaarField; set => finansaarField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 3)]
    public string CoesaFormalRef
    {
        get => coesaFormalRefField; set => coesaFormalRefField = value;
    }
}
