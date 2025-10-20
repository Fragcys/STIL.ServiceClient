using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class UmoHentListeResponseMessage
{
    private int[] umoHentListeResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Namespace = "http://xprs.dk/2005/08/17/", Order = 0)]
    [System.Xml.Serialization.XmlArrayItem("Delta", IsNullable = false)]
    public int[] UmoHentListeResponse
    {
        get => umoHentListeResponseField;
        set => umoHentListeResponseField = value;
    }
}