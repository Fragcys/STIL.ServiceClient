using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class TaksonomiVaerdiInfoType
{

    private string taksonomiIVaerdiDField;

    private string taksonomiRefField;

    private string taksonomiVaerdiField;

    private string betegnelseField;

    private string rangOrdenField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string TaksonomiIVaerdiD
    {
        get => taksonomiIVaerdiDField; set => taksonomiIVaerdiDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string TaksonomiRef
    {
        get => taksonomiRefField; set => taksonomiRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string TaksonomiVaerdi
    {
        get => taksonomiVaerdiField; set => taksonomiVaerdiField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 4)]
    public string RangOrden
    {
        get => rangOrdenField; set => rangOrdenField = value;
    }
}
