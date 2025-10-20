using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class SuUddannelserInfoType
{
    private string suUddannelseIDField;
    private string uddannelseRefField;
    private string specialeRefField;
    private string adgangsvejRefField;
    private string elevtypeRefField;
    private string maanederField;
    private string gF1Field;
    private string gF2Field;
    private string hfField;

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string SuUddannelseID { get => suUddannelseIDField; set => suUddannelseIDField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef { get => uddannelseRefField; set => uddannelseRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SpecialeRef { get => specialeRefField; set => specialeRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 3)]
    public string AdgangsvejRef { get => adgangsvejRefField; set => adgangsvejRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 4)]
    public string ElevtypeRef { get => elevtypeRefField; set => elevtypeRefField = value; }

    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 5)]
    public string Maaneder { get => maanederField; set => maanederField = value; }

    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string GF1 { get => gF1Field; set => gF1Field = value; }

    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string GF2 { get => gF2Field; set => gF2Field = value; }

    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string HF { get => hfField; set => hfField = value; }
}
