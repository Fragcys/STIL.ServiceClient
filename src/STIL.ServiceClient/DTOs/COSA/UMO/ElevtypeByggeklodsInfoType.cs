using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class ElevtypeByggeklodsInfoType
{

    private string elevtypeByggeklodsIDField;

    private string elevtypeByggeklodsField;

    private string kortBetegnelseField;

    private string betegnelseField;

    private string ungdomVoksenField;

    private string talentsporField;

    private string euxField;

    private string gymField;

    private string mesterlereField;

    private string pskoleEudField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string ElevtypeByggeklodsID
    {
        get => elevtypeByggeklodsIDField; set => elevtypeByggeklodsIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string ElevtypeByggeklods
    {
        get => elevtypeByggeklodsField; set => elevtypeByggeklodsField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string KortBetegnelse
    {
        get => kortBetegnelseField; set => kortBetegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Betegnelse
    {
        get => betegnelseField; set => betegnelseField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public string UngdomVoksen
    {
        get => ungdomVoksenField; set => ungdomVoksenField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string Talentspor
    {
        get => talentsporField; set => talentsporField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public string Eux
    {
        get => euxField; set => euxField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public string Gym
    {
        get => gymField; set => gymField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string Mesterlere
    {
        get => mesterlereField; set => mesterlereField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string PskoleEud
    {
        get => pskoleEudField; set => pskoleEudField = value;
    }
}
