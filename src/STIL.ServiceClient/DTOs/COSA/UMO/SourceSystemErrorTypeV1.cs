using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class SourceSystemErrorTypeV1
{

    private string sourceSystemNameField;

    private string errorCodeField;

    private string detailsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string SourceSystemName
    {
        get => sourceSystemNameField;
        set => sourceSystemNameField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string ErrorCode
    {
        get => errorCodeField;
        set => errorCodeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Details
    {
        get => detailsField;
        set => detailsField = value;
    }
}