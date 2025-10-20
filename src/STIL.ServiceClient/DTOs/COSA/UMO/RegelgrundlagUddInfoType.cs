using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class RegelgrundlagUddInfoType
{

    private string regelgrundlagUddIDField;

    private string uddannelseRefField;

    private string regelgrundlagRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string RegelgrundlagUddID
    {
        get => regelgrundlagUddIDField; set => regelgrundlagUddIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef
    {
        get => uddannelseRefField; set => uddannelseRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string RegelgrundlagRef
    {
        get => regelgrundlagRefField; set => regelgrundlagRefField = value;
    }
}
