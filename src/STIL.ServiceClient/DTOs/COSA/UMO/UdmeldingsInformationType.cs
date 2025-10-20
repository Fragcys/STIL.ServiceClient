using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UdmeldingsInformationType
{

    private UdmeldingsInformationInfoType udmeldingsInformationInfoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public UdmeldingsInformationInfoType UdmeldingsInformationInfo
    {
        get => udmeldingsInformationInfoField; set => udmeldingsInformationInfoField = value;
    }
}
