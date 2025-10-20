using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class UmoHentListeRequest
{
    private Identifier identifierField;

    private UmoHentListeRequestMessage messageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public Identifier Identifier
    {
        get => identifierField;
        set => identifierField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public UmoHentListeRequestMessage Message
    {
        get => messageField; set => messageField = value;
    }
}
