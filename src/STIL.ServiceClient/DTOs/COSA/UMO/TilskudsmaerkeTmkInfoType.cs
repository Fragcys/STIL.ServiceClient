using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class TilskudsmaerkeTmkInfoType
{
    private string tilskudsmaerkeTmkIDField;
    private string tilskudsmaerkeRefField;
    private string tmkRefField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string TilskudsmaerkeTmkID { get => tilskudsmaerkeTmkIDField; set => tilskudsmaerkeTmkIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string TilskudsmaerkeRef { get => tilskudsmaerkeRefField; set => tilskudsmaerkeRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string TmkRef { get => tmkRefField; set => tmkRefField = value; }
}
