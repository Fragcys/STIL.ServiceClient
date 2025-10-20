using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class AmuMaalInfoType
{

    private string fagIDField;

    private string certMeritEudField;

    private string certKontrUddField;

    private string certAdgMalField;

    private string optagelseField;

    private string indholdField;

    private string varighedField;

    private string eksamenField;

    private string maalformuleringField;

    private string bedoemmelserField;

    private string certifikatuddannelserField;

    private string faelleskatalogField;

    private string moderUddIdField;

    private string stillerUdstyrTilRField;

    private string certMyndighedField;

    private string certBrancheField;

    private string certUdstederField;

    private string certNavnField;

    private string certHjemmelField;

    private string certAndetSprogField;

    private string certAndetSprogBemaerkningField;

    private string certBemaerkningField;

    private string dispensationTil3AarsRegelField;

    private string formaalField;

    private string certBeskrivelseField;

    private string branchecertifikatField;

    private string fagRefField;

    private DateTime arkivdatoField;

    private bool arkivdatoFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagID
    {
        get => fagIDField; set => fagIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string CertMeritEud
    {
        get => certMeritEudField; set => certMeritEudField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string CertKontrUdd
    {
        get => certKontrUddField; set => certKontrUddField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string CertAdgMal
    {
        get => certAdgMalField; set => certAdgMalField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string Optagelse
    {
        get => optagelseField; set => optagelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string Indhold
    {
        get => indholdField; set => indholdField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string Varighed
    {
        get => varighedField; set => varighedField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string Eksamen
    {
        get => eksamenField; set => eksamenField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string Maalformulering
    {
        get => maalformuleringField; set => maalformuleringField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string Bedoemmelser
    {
        get => bedoemmelserField; set => bedoemmelserField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string Certifikatuddannelser
    {
        get => certifikatuddannelserField; set => certifikatuddannelserField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 11)]
    public string Faelleskatalog
    {
        get => faelleskatalogField; set => faelleskatalogField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 12)]
    public string ModerUddId
    {
        get => moderUddIdField; set => moderUddIdField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 13)]
    public string StillerUdstyrTilR
    {
        get => stillerUdstyrTilRField; set => stillerUdstyrTilRField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 14)]
    public string CertMyndighed
    {
        get => certMyndighedField; set => certMyndighedField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 15)]
    public string CertBranche
    {
        get => certBrancheField; set => certBrancheField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 16)]
    public string CertUdsteder
    {
        get => certUdstederField; set => certUdstederField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 17)]
    public string CertNavn
    {
        get => certNavnField; set => certNavnField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 18)]
    public string CertHjemmel
    {
        get => certHjemmelField; set => certHjemmelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 19)]
    public string CertAndetSprog
    {
        get => certAndetSprogField; set => certAndetSprogField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 20)]
    public string CertAndetSprogBemaerkning
    {
        get => certAndetSprogBemaerkningField; set => certAndetSprogBemaerkningField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 21)]
    public string CertBemaerkning
    {
        get => certBemaerkningField; set => certBemaerkningField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 22)]
    public string DispensationTil3AarsRegel
    {
        get => dispensationTil3AarsRegelField; set => dispensationTil3AarsRegelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 23)]
    public string Formaal
    {
        get => formaalField; set => formaalField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 24)]
    public string CertBeskrivelse
    {
        get => certBeskrivelseField; set => certBeskrivelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 25)]
    public string Branchecertifikat
    {
        get => branchecertifikatField; set => branchecertifikatField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 26)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 27)]
    public DateTime Arkivdato
    {
        get => arkivdatoField; set => arkivdatoField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool ArkivdatoSpecified
    {
        get => arkivdatoFieldSpecified; set => arkivdatoFieldSpecified = value;
    }
}
