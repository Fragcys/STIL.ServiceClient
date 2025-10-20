using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

/// <summary>
/// ServiceFaultDetailer.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class ServiceFaultDetailer
{

    private string correlationIDField;

    private DateTime timestampField;

    private string errorCodeField;

    private string errorMessageField;

    private string detailsField;

    private SourceSystemErrorTypeV1 sourceSystemErrorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string CorrelationID
    {
        get => correlationIDField;
        set => correlationIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public DateTime Timestamp
    {
        get => timestampField;
        set => timestampField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string ErrorCode
    {
        get => errorCodeField;
        set => errorCodeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string ErrorMessage
    {
        get => errorMessageField;
        set => errorMessageField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Details
    {
        get => detailsField;
        set => detailsField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public SourceSystemErrorTypeV1 SourceSystemError
    {
        get => sourceSystemErrorField;
        set => sourceSystemErrorField = value;
    }
}