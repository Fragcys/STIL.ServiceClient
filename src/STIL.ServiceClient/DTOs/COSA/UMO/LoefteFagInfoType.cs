using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class LoefteFagInfoType
{

    private string loefteFagIDField;

    private string regelgrundlagRefField;

    private string fraNiveauRefField;

    private string tilNiveauRefField;

    private decimal varighedKlokketimerField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string LoefteFagID
    {
        get => loefteFagIDField; set => loefteFagIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string RegelgrundlagRef
    {
        get => regelgrundlagRefField; set => regelgrundlagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string FraNiveauRef
    {
        get => fraNiveauRefField; set => fraNiveauRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 3)]
    public string TilNiveauRef
    {
        get => tilNiveauRefField; set => tilNiveauRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public decimal VarighedKlokketimer
    {
        get => varighedKlokketimerField; set => varighedKlokketimerField = value;
    }
}
