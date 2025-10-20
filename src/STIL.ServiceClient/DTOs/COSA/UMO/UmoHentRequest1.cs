using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://xprs.dk/2005/08/17/")]
public class UmoHentRequest1
{

    private int cVRSField;

    private int cVRIField;

    private string systemTypeKodeField;

    private int deltaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public int CVRS
    {
        get => cVRSField; set => cVRSField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public int CVRI
    {
        get => cVRIField; set => cVRIField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string SystemTypeKode
    {
        get => systemTypeKodeField; set => systemTypeKodeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public int Delta
    {
        get => deltaField; set => deltaField = value;
    }
}