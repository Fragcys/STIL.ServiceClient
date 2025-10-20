using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ResultatformFagInfoType
{
    private string resformFagIDField;
    private string resultatformRefField;
    private string fagRefField;
    private DateTime gyldigFraField;
    private DateTime gyldigTilField;
    private bool gyldigTilFieldSpecified;
    private string slettesField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ResformFagID { get => resformFagIDField; set => resformFagIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string ResultatformRef { get => resultatformRefField; set => resultatformRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string FagRef { get => fagRefField; set => fagRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime GyldigFra { get => gyldigFraField; set => gyldigFraField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime GyldigTil { get => gyldigTilField; set => gyldigTilField = value; }

    [System.Xml.Serialization.XmlIgnore()]
    public bool GyldigTilSpecified { get => gyldigTilFieldSpecified; set => gyldigTilFieldSpecified = value; }

    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string Slettes { get => slettesField; set => slettesField = value; }
}
