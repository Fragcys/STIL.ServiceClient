using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UdmeldingsInformationInfoType
{

    private string udmeldingsIdField;

    private string udmeldingsNummerField;

    private DateTime udmeldingsDatoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UdmeldingsId
    {
        get => udmeldingsIdField; set => udmeldingsIdField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 1)]
    public string UdmeldingsNummer
    {
        get => udmeldingsNummerField; set => udmeldingsNummerField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 2)]
    public DateTime UdmeldingsDato
    {
        get => udmeldingsDatoField; set => udmeldingsDatoField = value;
    }
}
