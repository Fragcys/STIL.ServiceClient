using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The skole fag pa hold udliciteret til class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skoleFagPaHoldUdliciteretTil
{
    /// <summary>
    /// The rnr field.
    /// </summary>
    private string cVRnrField;

    /// <summary>
    /// The pnummer field.
    /// </summary>
    private string pnummerField;

    /// <summary>
    /// Gets or sets the <see cref="CVRnr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string CVRnr
    {
        get => cVRnrField;
        set => cVRnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Pnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Pnummer
    {
        get => pnummerField;
        set => pnummerField = value;
    }
}