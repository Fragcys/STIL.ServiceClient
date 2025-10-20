using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class EvalueringsformInfoType
{

    private string evalueringsformIDField;

    private string evalueringsformField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string tidsafhaengigField;

    private string censurnormTypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string EvalueringsformID
    {
        get => evalueringsformIDField; set => evalueringsformIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Evalueringsform
    {
        get => evalueringsformField; set => evalueringsformField = value;
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
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Tidsafhaengig
    {
        get => tidsafhaengigField; set => tidsafhaengigField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string CensurnormType
    {
        get => censurnormTypeField; set => censurnormTypeField = value;
    }
}
