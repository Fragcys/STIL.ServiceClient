using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class RegelgrundlagInfoType
{

    private string regelgrundlagIDField;

    private RegelgrundlagType regelgrundlagField;

    private string titelField;

    private DateTime ikrafttraedelsesdatoField;

    private string urlField;

    private string regelgrundlagRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string RegelgrundlagID
    {
        get => regelgrundlagIDField; set => regelgrundlagIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public RegelgrundlagType Regelgrundlag
    {
        get => regelgrundlagField; set => regelgrundlagField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Titel
    {
        get => titelField; set => titelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime Ikrafttraedelsesdato
    {
        get => ikrafttraedelsesdatoField; set => ikrafttraedelsesdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Url
    {
        get => urlField; set => urlField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 5)]
    public string RegelgrundlagRef
    {
        get => regelgrundlagRefField; set => regelgrundlagRefField = value;
    }
}
