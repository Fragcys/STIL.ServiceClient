using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class RegelgrundlagFagInfoType
{

    private string regelgrundlagFagIDField;

    private string regelgrundlagRefField;

    private string fagRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string RegelgrundlagFagID
    {
        get => regelgrundlagFagIDField; set => regelgrundlagFagIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string RegelgrundlagRef
    {
        get => regelgrundlagRefField; set => regelgrundlagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }
}
