using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UddFrmSprogInfoType
{
    private string uddFrmSprogIDField;
    private string uddannelseRefField;
    private string sprogRefField;
    private string kortBetegnelseField;
    private string betegnelseField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UddFrmSprogID { get => uddFrmSprogIDField; set => uddFrmSprogIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef { get => uddannelseRefField; set => uddannelseRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SprogRef { get => sprogRefField; set => sprogRefField = value; }

    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string KortBetegnelse { get => kortBetegnelseField; set => kortBetegnelseField = value; }

    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Betegnelse { get => betegnelseField; set => betegnelseField = value; }
}
