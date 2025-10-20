using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagFrmSprogInfoType
{

    private string fagFrmSprogIDField;

    private string fagRefField;

    private string sprogRefField;

    private string kortBetegnelseField;

    private string betegnelseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagFrmSprogID
    {
        get => fagFrmSprogIDField; set => fagFrmSprogIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SprogRef
    {
        get => sprogRefField; set => sprogRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string KortBetegnelse
    {
        get => kortBetegnelseField; set => kortBetegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }
}
