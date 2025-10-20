using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UddannelseTakstInfoType
{
    private string uddannelseTakstIDField;
    private string coesaFormaalRefField;
    private string takstRefField;
    private string slettesField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UddannelseTakstID { get => uddannelseTakstIDField; set => uddannelseTakstIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string CoesaFormaalRef { get => coesaFormaalRefField; set => coesaFormaalRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string TakstRef { get => takstRefField; set => takstRefField = value; }

    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Slettes { get => slettesField; set => slettesField = value; }
}
