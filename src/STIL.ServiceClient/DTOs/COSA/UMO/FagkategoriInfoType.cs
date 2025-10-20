using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagkategoriInfoType
{

    private string fagkategoriIDField;

    private string fagkategoriField;

    private string betegnelseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagkategoriID
    {
        get => fagkategoriIDField; set => fagkategoriIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Fagkategori
    {
        get => fagkategoriField; set => fagkategoriField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }
}
