using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagSpecialeInfoType
{
    private string fagSpecialeIDField;
    private string fagRefField;
    private string specialeRefField;
    private string specialeFagtypeField;
    private DateTime gyldigFraField;
    private DateTime gyldigTilField;
    private bool gyldigTilFieldSpecified;
    private string elevTypeSamlingRefField;
    private string gF1Field;
    private string gF2Field;
    private string hfField;
    private string regelgrundlagRefField;
    private string afkortningField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagSpecialeID { get => fagSpecialeIDField; set => fagSpecialeIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string FagRef { get => fagRefField; set => fagRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SpecialeRef { get => specialeRefField; set => specialeRefField = value; }

    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string SpecialeFagtype { get => specialeFagtypeField; set => specialeFagtypeField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime GyldigFra { get => gyldigFraField; set => gyldigFraField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 5)]
    public DateTime GyldigTil { get => gyldigTilField; set => gyldigTilField = value; }

    [System.Xml.Serialization.XmlIgnore()]
    public bool GyldigTilSpecified { get => gyldigTilFieldSpecified; set => gyldigTilFieldSpecified = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 6)]
    public string ElevTypeSamlingRef { get => elevTypeSamlingRefField; set => elevTypeSamlingRefField = value; }

    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string GF1 { get => gF1Field; set => gF1Field = value; }

    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string GF2 { get => gF2Field; set => gF2Field = value; }

    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string HF { get => hfField; set => hfField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 10)]
    public string RegelgrundlagRef { get => regelgrundlagRefField; set => regelgrundlagRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 11)]
    public string Afkortning { get => afkortningField; set => afkortningField = value; }
}
