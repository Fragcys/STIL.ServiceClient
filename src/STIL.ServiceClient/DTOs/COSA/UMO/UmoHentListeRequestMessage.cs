using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class UmoHentListeRequestMessage
{
    private UmoHentListeRequest1 umoHentListeRequestField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Namespace = "http://xprs.dk/2005/08/17/", Order = 0)]
    public UmoHentListeRequest1 UmoHentListeRequest
    {
        get => umoHentListeRequestField;
        set => umoHentListeRequestField = value;
    }
}