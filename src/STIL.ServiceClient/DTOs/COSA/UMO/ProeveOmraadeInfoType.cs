using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ProeveOmraadeInfoType
{

    private string proeveOmraadeIDField;

    private string proeveOmraadeField;

    private string betegnelseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ProeveOmraadeID
    {
        get => proeveOmraadeIDField; set => proeveOmraadeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string ProeveOmraade
    {
        get => proeveOmraadeField; set => proeveOmraadeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }
}
