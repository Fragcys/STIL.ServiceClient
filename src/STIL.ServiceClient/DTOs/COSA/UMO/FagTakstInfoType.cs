using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagTakstInfoType
{
    private string fagTakstIDField;
    private string fagRefField;
    private string takstRefField;
    private string slettesField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagTakstID { get => fagTakstIDField; set => fagTakstIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagRef { get => fagRefField; set => fagRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string TakstRef { get => takstRefField; set => takstRefField = value; }

    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Slettes { get => slettesField; set => slettesField = value; }
}
