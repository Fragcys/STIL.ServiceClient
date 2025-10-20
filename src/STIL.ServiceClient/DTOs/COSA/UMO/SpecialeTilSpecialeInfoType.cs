using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class SpecialeTilSpecialeInfoType
{

    private string specialeTilSpecialeIDField;

    private string specialeFRefField;

    private string specialeBRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string SpecialeTilSpecialeID
    {
        get => specialeTilSpecialeIDField; set => specialeTilSpecialeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string SpecialeFRef
    {
        get => specialeFRefField; set => specialeFRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string SpecialeBRef
    {
        get => specialeBRefField; set => specialeBRefField = value;
    }
}
