using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class AmuOpgaveSaetInfoType
{

    private string amuProeveRefField;

    private byte[] beskrivelseUploadField;

    private byte[] bedomGrundlagUploadField;

    private byte[] bedomKritUploadField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string AmuProeveRef
    {
        get => amuProeveRefField; set => amuProeveRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "base64Binary", Order = 1)]
    public byte[] BeskrivelseUpload
    {
        get => beskrivelseUploadField; set => beskrivelseUploadField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "base64Binary", Order = 2)]
    public byte[] BedomGrundlagUpload
    {
        get => bedomGrundlagUploadField; set => bedomGrundlagUploadField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "base64Binary", Order = 3)]
    public byte[] BedomKritUpload
    {
        get => bedomKritUploadField; set => bedomKritUploadField = value;
    }
}
