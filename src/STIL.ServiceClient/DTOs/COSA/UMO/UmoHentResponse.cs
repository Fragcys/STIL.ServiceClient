using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Xml.Serialization.XmlRoot(ElementName = "UmoHentResponse", Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class UmoHentResponse
{

    private Identifier identifierField;

    private string correlationIDField;

    private UmoHentResponseMessage messageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public Identifier Identifier
    {
        get => identifierField; set => identifierField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string CorrelationID
    {
        get => correlationIDField; set => correlationIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public UmoHentResponseMessage Message
    {
        get => messageField; set => messageField = value;
    }
}
