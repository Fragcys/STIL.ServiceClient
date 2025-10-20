using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ElevtypeSkoleperiodeInfoType
{
    private string elevtypeSkoleperiodeIDField;
    private string elevtypeSamlingRefField;
    private string skoleperiodeRefField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ElevtypeSkoleperiodeID { get => elevtypeSkoleperiodeIDField; set => elevtypeSkoleperiodeIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string ElevtypeSamlingRef { get => elevtypeSamlingRefField; set => elevtypeSamlingRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SkoleperiodeRef { get => skoleperiodeRefField; set => skoleperiodeRefField = value; }
}
