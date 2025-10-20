using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UddannelseProeveInfoType
{
    private string uddannelseProeveIDField;
    private string uddannelseRefField;
    private string centraltStilledeOpgaverField;
    private string skrAntalCensorerField;
    private string antalTilladteProeverPrDagField;
    private string indberetningspligtKodeField;
    private string proevedeltagelseKodeSkrField;
    private string proevedeltagelseKodeMdtField;
    private string centralCensurKodeField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UddannelseProeveID { get => uddannelseProeveIDField; set => uddannelseProeveIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef { get => uddannelseRefField; set => uddannelseRefField = value; }

    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string CentraltStilledeOpgaver { get => centraltStilledeOpgaverField; set => centraltStilledeOpgaverField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 3)]
    public string SkrAntalCensorer { get => skrAntalCensorerField; set => skrAntalCensorerField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 4)]
    public string AntalTilladteProeverPrDag { get => antalTilladteProeverPrDagField; set => antalTilladteProeverPrDagField = value; }

    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string IndberetningspligtKode { get => indberetningspligtKodeField; set => indberetningspligtKodeField = value; }

    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string ProevedeltagelseKodeSkr { get => proevedeltagelseKodeSkrField; set => proevedeltagelseKodeSkrField = value; }

    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string ProevedeltagelseKodeMdt { get => proevedeltagelseKodeMdtField; set => proevedeltagelseKodeMdtField = value; }

    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string CentralCensurKode { get => centralCensurKodeField; set => centralCensurKodeField = value; }
}
