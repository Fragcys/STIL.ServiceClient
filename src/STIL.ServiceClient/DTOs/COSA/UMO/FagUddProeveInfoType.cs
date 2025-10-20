using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagUddProeveInfoType
{
    private string fagUddProeveIDField;
    private string fagUddRefField;
    private string indberetningspligtKodeField;
    private string proevedeltagelseKodeSkrField;
    private string proevedeltagelseKodeMdtField;
    private string centralCensurKodeField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagUddProeveID { get => fagUddProeveIDField; set => fagUddProeveIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagUddRef { get => fagUddRefField; set => fagUddRefField = value; }

    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string IndberetningspligtKode { get => indberetningspligtKodeField; set => indberetningspligtKodeField = value; }

    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string ProevedeltagelseKodeSkr { get => proevedeltagelseKodeSkrField; set => proevedeltagelseKodeSkrField = value; }

    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string ProevedeltagelseKodeMdt { get => proevedeltagelseKodeMdtField; set => proevedeltagelseKodeMdtField = value; }

    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string CentralCensurKode { get => centralCensurKodeField; set => centralCensurKodeField = value; }
}
