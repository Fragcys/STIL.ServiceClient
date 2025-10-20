using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ElevtypeElevtypeByggeklodsInfoType
{

    private string elevtypeElevtypeByggeklodsIDField;

    private string elevtypeRefField;

    private string elevtypeByggeklodsRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ElevtypeElevtypeByggeklodsID
    {
        get => elevtypeElevtypeByggeklodsIDField; set => elevtypeElevtypeByggeklodsIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string ElevtypeRef
    {
        get => elevtypeRefField; set => elevtypeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string ElevtypeByggeklodsRef
    {
        get => elevtypeByggeklodsRefField; set => elevtypeByggeklodsRefField = value;
    }
}
