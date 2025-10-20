using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Xml.Serialization.XmlRoot(ElementName = "UmoHentListeResponse", Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class UmoHentListeResponse
{
    private Identifier identifierField;

    private string correlationIDField;

    private UmoHentListeResponseMessage messageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public Identifier Identifier
    {
        get => identifierField;
        set => identifierField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string CorrelationID
    {
        get => correlationIDField;
        set => correlationIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public UmoHentListeResponseMessage Message
    {
        get => messageField;
        set => messageField = value;
    }
}
