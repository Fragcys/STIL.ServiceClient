using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagType
{

    private string fagNummerField;

    private string niveauRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 0)]
    public string FagNummer
    {
        get => fagNummerField; set => fagNummerField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string NiveauRef
    {
        get => niveauRefField; set => niveauRefField = value;
    }
}
