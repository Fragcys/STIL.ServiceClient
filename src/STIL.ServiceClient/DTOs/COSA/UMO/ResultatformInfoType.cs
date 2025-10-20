using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ResultatformInfoType
{
    private string resultatformIDField;
    private string evalueringsformRefField;
    private string karakterTypeRefField;
    private string karakterSkalaRefField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ResultatformID { get => resultatformIDField; set => resultatformIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string EvalueringsformRef { get => evalueringsformRefField; set => evalueringsformRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string KarakterTypeRef { get => karakterTypeRefField; set => karakterTypeRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 3)]
    public string KarakterSkalaRef { get => karakterSkalaRefField; set => karakterSkalaRefField = value; }
}
