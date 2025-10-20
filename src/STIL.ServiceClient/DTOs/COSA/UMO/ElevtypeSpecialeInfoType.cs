using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ElevtypeSpecialeInfoType
{
    private string elevtypeSpecialeIDField;
    private string elevtypeUddannelseRefField;
    private string specialeRefField;
    private DateTime gyldigFraField;
    private DateTime gyldigTilField;
    private bool gyldigTilFieldSpecified;
    private string uddannelseVarighedAarField;
    private decimal uddannelseVarighedMaanedField;
    private decimal skoleopholdHovedField;
    private decimal skoleopholdGF1Field;
    private decimal skoleopholdGF2Field;
    private decimal varighedEuxField;
    private decimal studierettetForloebEuxField;
    private decimal rkvOpholdEuvField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ElevtypeSpecialeID { get => elevtypeSpecialeIDField; set => elevtypeSpecialeIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string ElevtypeUddannelseRef { get => elevtypeUddannelseRefField; set => elevtypeUddannelseRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SpecialeRef { get => specialeRefField; set => specialeRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime GyldigFra { get => gyldigFraField; set => gyldigFraField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime GyldigTil { get => gyldigTilField; set => gyldigTilField = value; }

    [System.Xml.Serialization.XmlIgnore()]
    public bool GyldigTilSpecified { get => gyldigTilFieldSpecified; set => gyldigTilFieldSpecified = value; }

    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 5)]
    public string UddannelseVarighedAar { get => uddannelseVarighedAarField; set => uddannelseVarighedAarField = value; }

    [System.Xml.Serialization.XmlElement(Order = 6)]
    public decimal UddannelseVarighedMaaned { get => uddannelseVarighedMaanedField; set => uddannelseVarighedMaanedField = value; }

    [System.Xml.Serialization.XmlElement(Order = 7)]
    public decimal SkoleopholdHoved { get => skoleopholdHovedField; set => skoleopholdHovedField = value; }

    [System.Xml.Serialization.XmlElement(Order = 8)]
    public decimal SkoleopholdGF1 { get => skoleopholdGF1Field; set => skoleopholdGF1Field = value; }

    [System.Xml.Serialization.XmlElement(Order = 9)]
    public decimal SkoleopholdGF2 { get => skoleopholdGF2Field; set => skoleopholdGF2Field = value; }

    [System.Xml.Serialization.XmlElement(Order = 10)]
    public decimal VarighedEux { get => varighedEuxField; set => varighedEuxField = value; }

    [System.Xml.Serialization.XmlElement(Order = 11)]
    public decimal StudierettetForloebEux { get => studierettetForloebEuxField; set => studierettetForloebEuxField = value; }

    [System.Xml.Serialization.XmlElement(Order = 12)]
    public decimal RkvOpholdEuv { get => rkvOpholdEuvField; set => rkvOpholdEuvField = value; }
}
