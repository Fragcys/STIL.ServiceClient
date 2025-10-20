using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class JurEnhedAeAfdelingInfoType
{

    private string jurEnhedAeAfdelingIDField;

    private string jurEnhedField;

    private string jurEnhedTypeField;

    private string aeAfdelingField;

    private string aeAfdelingTypeField;

    private DateTime startdatoField;

    private DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string JurEnhedAeAfdelingID
    {
        get => jurEnhedAeAfdelingIDField; set => jurEnhedAeAfdelingIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 1)]
    public string JurEnhed
    {
        get => jurEnhedField; set => jurEnhedField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string JurEnhedType
    {
        get => jurEnhedTypeField; set => jurEnhedTypeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 3)]
    public string AeAfdeling
    {
        get => aeAfdelingField; set => aeAfdelingField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string AeAfdelingType
    {
        get => aeAfdelingTypeField; set => aeAfdelingTypeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 5)]
    public DateTime Startdato
    {
        get => startdatoField; set => startdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 6)]
    public DateTime Slutdato
    {
        get => slutdatoField; set => slutdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool SlutdatoSpecified
    {
        get => slutdatoFieldSpecified; set => slutdatoFieldSpecified = value;
    }
}
