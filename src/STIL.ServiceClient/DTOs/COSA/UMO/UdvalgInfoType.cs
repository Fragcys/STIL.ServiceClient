using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class UdvalgInfoType
{

    private string udvalgIDField;

    private string udvalgField;

    private string udvalgsTypeField;

    private string navnField;

    private string adresse1Field;

    private string adresse2Field;

    private string adresse3Field;

    private string telefonField;

    private string faxField;

    private string emailField;

    private string kontaktPersonField;

    private string kontaktPersonEmailField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string UdvalgID
    {
        get => udvalgIDField; set => udvalgIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Udvalg
    {
        get => udvalgField; set => udvalgField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string UdvalgsType
    {
        get => udvalgsTypeField; set => udvalgsTypeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Navn
    {
        get => navnField; set => navnField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Adresse1
    {
        get => adresse1Field; set => adresse1Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string Adresse2
    {
        get => adresse2Field; set => adresse2Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string Adresse3
    {
        get => adresse3Field; set => adresse3Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string Telefon
    {
        get => telefonField; set => telefonField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string Fax
    {
        get => faxField; set => faxField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string Email
    {
        get => emailField; set => emailField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string KontaktPerson
    {
        get => kontaktPersonField; set => kontaktPersonField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 11)]
    public string KontaktPersonEmail
    {
        get => kontaktPersonEmailField; set => kontaktPersonEmailField = value;
    }
}
