using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class EveGruppeTakstInfoType
{

    private string eveGruppeTakstIDField;

    private string eveGruppeRefField;

    private string takstRefField;

    private string slettesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string EveGruppeTakstID
    {
        get => eveGruppeTakstIDField; set => eveGruppeTakstIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string EveGruppeRef
    {
        get => eveGruppeRefField; set => eveGruppeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string TakstRef
    {
        get => takstRefField; set => takstRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Slettes
    {
        get => slettesField; set => slettesField = value;
    }
}
