using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

/// <summary>
/// The identifier class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/cosa/umo/v1.5")]
public class Identifier
{
    private string systemNameField;

    private string systemTransactionIDField;

    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string SystemName
    {
        get => systemNameField; set => systemNameField = value;
    }

    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string SystemTransactionID
    {
        get => systemTransactionIDField; set => systemTransactionIDField = value;
    }
}