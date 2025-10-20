using System;

namespace STIL.ServiceClient.DTOs.COSA.UMO;

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://xprs.dk/2005/08/17/")]
public class UmoHentResponse1
{

    private UdmeldingsInformationType udmeldingsInformationField;

    private DomainInfoType[] domainTabelField;

    private DomainVaerdierInfoType[] domainVaerdierTabelField;

    private AdgangsvejInfoType[] adgangsvejTabelField;

    private BeregningstypeInfoType[] beregningstyperTabelField;

    private CentraleAfgangsAarsagerInfoType[] centraleAfgangsAarsagerTabelField;

    private ElevtypeSamlingInfoType[] elevtypeSamlingTabelField;

    private ElevtypeInfoType[] elevtypeTabelField;

    private ElevtypeByggeklodsInfoType[] elevtypeByggeklodsTabelField;

    private ElevtypeElevtypeSamlingInfoType[] elevtypeElevtypeSamlingTabelField;

    private EvalueringsformInfoType[] evalueringsformTabelField;

    private FaggrupperingInfoType[] faggrupperingTabelField;

    private FagkategoriInfoType[] fagkategoriTabelField;

    private FormaalsgruppeInfoType[] formaalsgruppeTabelField;

    private FrmSprogInfoType[] frmSprogTabelField;

    private KarakterskalaInfoType[] karakterskalaTabelField;

    private KaraktertypeInfoType[] karaktertypeTabelField;

    private KompetenceInfoType[] kompetenceTabelField;

    private NiveautypeInfoType[] niveautyperTabelField;

    private PeriodetypeInfoType[] periodetypeTabelField;

    private ProeveOmraadeInfoType[] proeveOmraadeTabelField;

    private RegelgrundlagInfoType[] regelgrundlagTabelField;

    private TaksttypeInfoType[] taksttypeTabelField;

    private TilskudsmaerkeInfoType[] tilskudsmaerkeTabelField;

    private TmkInfoType[] tmkTabelField;

    private UdvalgInfoType[] udvalgTabelField;

    private BtypeTtypeTmerkeInfoType[] btypeTtypeTmerkerTabelField;

    private CoesaFormaalInfoType[] coesaFormaalTabelField;

    private UddannelsesKarakteristikaInfoType[] uddannelseskarakteristikaTabelField;

    private ElevtypeElevtypeByggeklodsInfoType[] elevtyElevTyByggeklodsTabelField;

    private NiveauInfoType[] niveauerTabelField;

    private FagInfoType[] fagTabelField;

    private KarakterVaerdiInfoType[] karakterVaerdiTabelField;

    private LoefteFagInfoType[] loefteFagTabelField;

    private KravDbFagInfoType[] kravDbFagTabelField;

    private TaksonomiInfoType[] taksonomiTabelField;

    private TaksonomiVaerdiInfoType[] taksonomiVaerdiTabelField;

    private TakstInfoType[] takstTabelField;

    private EveGruppeInfoType[] eveGruppeTabelField;

    private EveGruppeFagInfoType[] eveGruppeFagTabelField;

    private EveGruppeTakstInfoType[] eveGruppeTakstTabelField;

    private FagKonteringInfoType[] fagKonteringTabelField;

    private UddannelseInfoType[] uddannelseTabelField;

    private AmuMaalInfoType[] amumaalTabelField;

    private AmuProeveInfoType[] amuProeveTabelField;

    private AmuOpgaveSaetInfoType[] amuOpgaveSaetTabelField;

    private BevislinjeInfoType[] bevislinjeTabelField;

    private MultiplanFagInfoType[] multiplanFagTabelField;

    private MultiplanFagValgmulighederInfoType[] multiplanFagValgmulighederTabelField;

    private StudieretHfOverbygInfoType[] studieretHfOverbygTabelField;

    private ElevtypeUddannelseInfoType[] elevtypeUddannelseTabelField;

    private FagFaggrupperingsInfoType[] fagFaggrupperingsTabelField;

    private FagFrmSprogInfoType[] fagFrmSprogTabelField;

    private FagUddInfoType[] fagUddTabelField;

    private GodkendelsePaaSkoleInfoType[] godkendelsePaaSkoleTabelField;

    private KompetenceFagInfoType[] kompetenceFagTabelField;

    private FagProeveInfoType[] fagProeveTabelField;

    private FasteUnderfagInfoType[] fasteUnderfagTabelField;

    private ProeveInfoType[] proeveTabelField;

    private MaalpindInfoType[] maalpindTabelField;

    private ProeveomraadeUddInfoType[] proeveomraadeUddTabelField;

    private RegelgrundlagFagInfoType[] regelgrundlagFagTabelField;

    private RegelgrundlagUddInfoType[] regelgrundlagUddTabelField;

    private SpecialeInfoType[] specialeTabelField;

    private SpecialeTilSpecialeInfoType[] specialeTilSpecialeTabelField;

    private SkoleperiodeInfoType[] skoleperiodeTabelField;

    private StudieretHfOverbygFagInfoType[] studieretHfOverbygFagTabelField;

    private TaelleperiodeInfoType[] taelleperiodeTabelField;

    private UddannelseAarsnormInfoType[] uddannelseAarsnormTabelField;

    private UddFrmSprogInfoType[] uddFrmSprogTabelField;

    private ElevtypeSpecialeInfoType[] elevtypeSpecialeTabelField;

    private ElevtypeSkoleperiodeInfoType[] elevtypeSkoleperiodeTabelField;

    private TilskudsmaerkeTmkInfoType[] tilskudsmaerkeTmkTabelField;

    private UddannelseProeveInfoType[] uddannelseProeveTabelField;

    private TmkSkoleperiodeInfoType[] tmkSkoleperiodeTabelField;

    private TmkAauInfoType[] tmkAauTabelField;

    private FagTakstInfoType[] fagTakstTabelField;

    private UddannelseTakstInfoType[] uddannelseTakstTabelField;

    private ResultatformInfoType[] resultatformTabelField;

    private ResultatformFagInfoType[] resultatformFagTabelField;

    private FagUddProeveInfoType[] fagUddProeveTabelField;

    private FagSpecialeInfoType[] fagSpecialeTabelField;

    private SuUddannelserInfoType[] suUddannelserTabelField;

    private JurEnhedAeAfdelingInfoType[] jurEnhedAeAfdelingTabelField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public UdmeldingsInformationType UdmeldingsInformation
    {
        get => udmeldingsInformationField; set => udmeldingsInformationField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 1)]
    [System.Xml.Serialization.XmlArrayItem("DomainInfo", IsNullable = false)]
    public DomainInfoType[] DomainTabel
    {
        get => domainTabelField; set => domainTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 2)]
    [System.Xml.Serialization.XmlArrayItem("DomainVaerdierInfo", IsNullable = false)]
    public DomainVaerdierInfoType[] DomainVaerdierTabel
    {
        get => domainVaerdierTabelField; set => domainVaerdierTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 3)]
    [System.Xml.Serialization.XmlArrayItem("AdgangsvejInfo", IsNullable = false)]
    public AdgangsvejInfoType[] AdgangsvejTabel
    {
        get => adgangsvejTabelField; set => adgangsvejTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 4)]
    [System.Xml.Serialization.XmlArrayItem("BeregningstypeInfo", IsNullable = false)]
    public BeregningstypeInfoType[] BeregningstyperTabel
    {
        get => beregningstyperTabelField; set => beregningstyperTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 5)]
    [System.Xml.Serialization.XmlArrayItem("CentraleAfgangsAarsagerInfo", IsNullable = false)]
    public CentraleAfgangsAarsagerInfoType[] CentraleAfgangsAarsagerTabel
    {
        get => centraleAfgangsAarsagerTabelField; set => centraleAfgangsAarsagerTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 6)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeSamlingInfo", IsNullable = false)]
    public ElevtypeSamlingInfoType[] ElevtypeSamlingTabel
    {
        get => elevtypeSamlingTabelField; set => elevtypeSamlingTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 7)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeInfo", IsNullable = false)]
    public ElevtypeInfoType[] ElevtypeTabel
    {
        get => elevtypeTabelField; set => elevtypeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 8)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeByggeklodsInfo", IsNullable = false)]
    public ElevtypeByggeklodsInfoType[] ElevtypeByggeklodsTabel
    {
        get => elevtypeByggeklodsTabelField; set => elevtypeByggeklodsTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 9)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeElevtypeSamlingInfo", IsNullable = false)]
    public ElevtypeElevtypeSamlingInfoType[] ElevtypeElevtypeSamlingTabel
    {
        get => elevtypeElevtypeSamlingTabelField; set => elevtypeElevtypeSamlingTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 10)]
    [System.Xml.Serialization.XmlArrayItem("EvalueringsformInfo", IsNullable = false)]
    public EvalueringsformInfoType[] EvalueringsformTabel
    {
        get => evalueringsformTabelField; set => evalueringsformTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 11)]
    [System.Xml.Serialization.XmlArrayItem("FaggrupperingInfo", IsNullable = false)]
    public FaggrupperingInfoType[] FaggrupperingTabel
    {
        get => faggrupperingTabelField; set => faggrupperingTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 12)]
    [System.Xml.Serialization.XmlArrayItem("FagkategoriInfo", IsNullable = false)]
    public FagkategoriInfoType[] FagkategoriTabel
    {
        get => fagkategoriTabelField; set => fagkategoriTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 13)]
    [System.Xml.Serialization.XmlArrayItem("FormaalsgruppeInfo", IsNullable = false)]
    public FormaalsgruppeInfoType[] FormaalsgruppeTabel
    {
        get => formaalsgruppeTabelField; set => formaalsgruppeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 14)]
    [System.Xml.Serialization.XmlArrayItem("FrmSprogInfo", IsNullable = false)]
    public FrmSprogInfoType[] FrmSprogTabel
    {
        get => frmSprogTabelField; set => frmSprogTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 15)]
    [System.Xml.Serialization.XmlArrayItem("KarakterskalaInfo", IsNullable = false)]
    public KarakterskalaInfoType[] KarakterskalaTabel
    {
        get => karakterskalaTabelField; set => karakterskalaTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 16)]
    [System.Xml.Serialization.XmlArrayItem("KaraktertypeInfo", IsNullable = false)]
    public KaraktertypeInfoType[] KaraktertypeTabel
    {
        get => karaktertypeTabelField; set => karaktertypeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 17)]
    [System.Xml.Serialization.XmlArrayItem("KompetenceInfo", IsNullable = false)]
    public KompetenceInfoType[] KompetenceTabel
    {
        get => kompetenceTabelField; set => kompetenceTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 18)]
    [System.Xml.Serialization.XmlArrayItem("NiveautypeInfo", IsNullable = false)]
    public NiveautypeInfoType[] NiveautyperTabel
    {
        get => niveautyperTabelField; set => niveautyperTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 19)]
    [System.Xml.Serialization.XmlArrayItem("PeriodetypeInfo", IsNullable = false)]
    public PeriodetypeInfoType[] PeriodetypeTabel
    {
        get => periodetypeTabelField; set => periodetypeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 20)]
    [System.Xml.Serialization.XmlArrayItem("ProeveOmraadeInfo", IsNullable = false)]
    public ProeveOmraadeInfoType[] ProeveOmraadeTabel
    {
        get => proeveOmraadeTabelField; set => proeveOmraadeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 21)]
    [System.Xml.Serialization.XmlArrayItem("RegelgrundlagInfo", IsNullable = false)]
    public RegelgrundlagInfoType[] RegelgrundlagTabel
    {
        get => regelgrundlagTabelField; set => regelgrundlagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 22)]
    [System.Xml.Serialization.XmlArrayItem("TaksttypeInfo", IsNullable = false)]
    public TaksttypeInfoType[] TaksttypeTabel
    {
        get => taksttypeTabelField; set => taksttypeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 23)]
    [System.Xml.Serialization.XmlArrayItem("TilskudsmaerkeInfo", IsNullable = false)]
    public TilskudsmaerkeInfoType[] TilskudsmaerkeTabel
    {
        get => tilskudsmaerkeTabelField; set => tilskudsmaerkeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 24)]
    [System.Xml.Serialization.XmlArrayItem("TmkInfo", IsNullable = false)]
    public TmkInfoType[] TmkTabel
    {
        get => tmkTabelField; set => tmkTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 25)]
    [System.Xml.Serialization.XmlArrayItem("UdvalgInfo", IsNullable = false)]
    public UdvalgInfoType[] UdvalgTabel
    {
        get => udvalgTabelField; set => udvalgTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 26)]
    [System.Xml.Serialization.XmlArrayItem("BtypeTtypeTmerkeInfo", IsNullable = false)]
    public BtypeTtypeTmerkeInfoType[] BtypeTtypeTmerkerTabel
    {
        get => btypeTtypeTmerkerTabelField; set => btypeTtypeTmerkerTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 27)]
    [System.Xml.Serialization.XmlArrayItem("CoesaFormaalInfo", IsNullable = false)]
    public CoesaFormaalInfoType[] CoesaFormaalTabel
    {
        get => coesaFormaalTabelField; set => coesaFormaalTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 28)]
    [System.Xml.Serialization.XmlArrayItem("UddannelsesKarakteristikaInfo", IsNullable = false)]
    public UddannelsesKarakteristikaInfoType[] UddannelseskarakteristikaTabel
    {
        get => uddannelseskarakteristikaTabelField; set => uddannelseskarakteristikaTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 29)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeElevtypeByggeklodsInfo", IsNullable = false)]
    public ElevtypeElevtypeByggeklodsInfoType[] ElevtyElevTyByggeklodsTabel
    {
        get => elevtyElevTyByggeklodsTabelField; set => elevtyElevTyByggeklodsTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 30)]
    [System.Xml.Serialization.XmlArrayItem("NiveauInfo", IsNullable = false)]
    public NiveauInfoType[] NiveauerTabel
    {
        get => niveauerTabelField; set => niveauerTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 31)]
    [System.Xml.Serialization.XmlArrayItem("FagInfo", IsNullable = false)]
    public FagInfoType[] FagTabel
    {
        get => fagTabelField; set => fagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 32)]
    [System.Xml.Serialization.XmlArrayItem("KarakterVaerdiInfo", IsNullable = false)]
    public KarakterVaerdiInfoType[] KarakterVaerdiTabel
    {
        get => karakterVaerdiTabelField; set => karakterVaerdiTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 33)]
    [System.Xml.Serialization.XmlArrayItem("LoefteFagInfo", IsNullable = false)]
    public LoefteFagInfoType[] LoefteFagTabel
    {
        get => loefteFagTabelField; set => loefteFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 34)]
    [System.Xml.Serialization.XmlArrayItem("KravDbFagInfo", IsNullable = false)]
    public KravDbFagInfoType[] KravDbFagTabel
    {
        get => kravDbFagTabelField; set => kravDbFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 35)]
    [System.Xml.Serialization.XmlArrayItem("TaksonomiInfo", IsNullable = false)]
    public TaksonomiInfoType[] TaksonomiTabel
    {
        get => taksonomiTabelField; set => taksonomiTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 36)]
    [System.Xml.Serialization.XmlArrayItem("TaksonomiVaerdiInfo", IsNullable = false)]
    public TaksonomiVaerdiInfoType[] TaksonomiVaerdiTabel
    {
        get => taksonomiVaerdiTabelField; set => taksonomiVaerdiTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 37)]
    [System.Xml.Serialization.XmlArrayItem("TakstInfo", IsNullable = false)]
    public TakstInfoType[] TakstTabel
    {
        get => takstTabelField; set => takstTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 38)]
    [System.Xml.Serialization.XmlArrayItem("EveGruppeInfo", IsNullable = false)]
    public EveGruppeInfoType[] EveGruppeTabel
    {
        get => eveGruppeTabelField; set => eveGruppeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 39)]
    [System.Xml.Serialization.XmlArrayItem("EveGruppeFagInfo", IsNullable = false)]
    public EveGruppeFagInfoType[] EveGruppeFagTabel
    {
        get => eveGruppeFagTabelField; set => eveGruppeFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 40)]
    [System.Xml.Serialization.XmlArrayItem("EveGruppeTakstInfo", IsNullable = false)]
    public EveGruppeTakstInfoType[] EveGruppeTakstTabel
    {
        get => eveGruppeTakstTabelField; set => eveGruppeTakstTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 41)]
    [System.Xml.Serialization.XmlArrayItem("FagKonteringInfo", IsNullable = false)]
    public FagKonteringInfoType[] FagKonteringTabel
    {
        get => fagKonteringTabelField; set => fagKonteringTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 42)]
    [System.Xml.Serialization.XmlArrayItem("UddannelseInfo", IsNullable = false)]
    public UddannelseInfoType[] UddannelseTabel
    {
        get => uddannelseTabelField; set => uddannelseTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 43)]
    [System.Xml.Serialization.XmlArrayItem("AmuMaalInfo", IsNullable = false)]
    public AmuMaalInfoType[] AmumaalTabel
    {
        get => amumaalTabelField; set => amumaalTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 44)]
    [System.Xml.Serialization.XmlArrayItem("AmuProeveInfo", IsNullable = false)]
    public AmuProeveInfoType[] AmuProeveTabel
    {
        get => amuProeveTabelField; set => amuProeveTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 45)]
    [System.Xml.Serialization.XmlArrayItem("AmuOpgaveSaetInfo", IsNullable = false)]
    public AmuOpgaveSaetInfoType[] AmuOpgaveSaetTabel
    {
        get => amuOpgaveSaetTabelField; set => amuOpgaveSaetTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 46)]
    [System.Xml.Serialization.XmlArrayItem("BevislinjeInfo", IsNullable = false)]
    public BevislinjeInfoType[] BevislinjeTabel
    {
        get => bevislinjeTabelField; set => bevislinjeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 47)]
    [System.Xml.Serialization.XmlArrayItem("MultiplanFagInfo", IsNullable = false)]
    public MultiplanFagInfoType[] MultiplanFagTabel
    {
        get => multiplanFagTabelField; set => multiplanFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 48)]
    [System.Xml.Serialization.XmlArrayItem("MultiplanFagValgmulighederInfo", IsNullable = false)]
    public MultiplanFagValgmulighederInfoType[] MultiplanFagValgmulighederTabel
    {
        get => multiplanFagValgmulighederTabelField; set => multiplanFagValgmulighederTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 49)]
    [System.Xml.Serialization.XmlArrayItem("StudieretHfOverbygInfo", IsNullable = false)]
    public StudieretHfOverbygInfoType[] StudieretHfOverbygTabel
    {
        get => studieretHfOverbygTabelField; set => studieretHfOverbygTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 50)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeUddannelseInfo", IsNullable = false)]
    public ElevtypeUddannelseInfoType[] ElevtypeUddannelseTabel
    {
        get => elevtypeUddannelseTabelField; set => elevtypeUddannelseTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 51)]
    [System.Xml.Serialization.XmlArrayItem("FagFaggrupperingsInfo", IsNullable = false)]
    public FagFaggrupperingsInfoType[] FagFaggrupperingsTabel
    {
        get => fagFaggrupperingsTabelField; set => fagFaggrupperingsTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 52)]
    [System.Xml.Serialization.XmlArrayItem("FagFrmSprogInfo", IsNullable = false)]
    public FagFrmSprogInfoType[] FagFrmSprogTabel
    {
        get => fagFrmSprogTabelField; set => fagFrmSprogTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 53)]
    [System.Xml.Serialization.XmlArrayItem("FagUddInfo", IsNullable = false)]
    public FagUddInfoType[] FagUddTabel
    {
        get => fagUddTabelField; set => fagUddTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 54)]
    [System.Xml.Serialization.XmlArrayItem("GodkendelsePaaSkoleInfo", IsNullable = false)]
    public GodkendelsePaaSkoleInfoType[] GodkendelsePaaSkoleTabel
    {
        get => godkendelsePaaSkoleTabelField; set => godkendelsePaaSkoleTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 55)]
    [System.Xml.Serialization.XmlArrayItem("KompetenceFagInfo", IsNullable = false)]
    public KompetenceFagInfoType[] KompetenceFagTabel
    {
        get => kompetenceFagTabelField; set => kompetenceFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 56)]
    [System.Xml.Serialization.XmlArrayItem("FagProeveInfo", IsNullable = false)]
    public FagProeveInfoType[] FagProeveTabel
    {
        get => fagProeveTabelField; set => fagProeveTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 57)]
    [System.Xml.Serialization.XmlArrayItem("FasteUnderfagInfo", IsNullable = false)]
    public FasteUnderfagInfoType[] FasteUnderfagTabel
    {
        get => fasteUnderfagTabelField; set => fasteUnderfagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 58)]
    [System.Xml.Serialization.XmlArrayItem("ProeveInfo", IsNullable = false)]
    public ProeveInfoType[] ProeveTabel
    {
        get => proeveTabelField; set => proeveTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 59)]
    [System.Xml.Serialization.XmlArrayItem("MaalpindInfo", IsNullable = false)]
    public MaalpindInfoType[] MaalpindTabel
    {
        get => maalpindTabelField; set => maalpindTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 60)]
    [System.Xml.Serialization.XmlArrayItem("ProeveomraadeUddInfo", IsNullable = false)]
    public ProeveomraadeUddInfoType[] ProeveomraadeUddTabel
    {
        get => proeveomraadeUddTabelField; set => proeveomraadeUddTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 61)]
    [System.Xml.Serialization.XmlArrayItem("RegelgrundlagFagInfo", IsNullable = false)]
    public RegelgrundlagFagInfoType[] RegelgrundlagFagTabel
    {
        get => regelgrundlagFagTabelField; set => regelgrundlagFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 62)]
    [System.Xml.Serialization.XmlArrayItem("RegelgrundlagUddInfo", IsNullable = false)]
    public RegelgrundlagUddInfoType[] RegelgrundlagUddTabel
    {
        get => regelgrundlagUddTabelField; set => regelgrundlagUddTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 63)]
    [System.Xml.Serialization.XmlArrayItem("SpecialeInfo", IsNullable = false)]
    public SpecialeInfoType[] SpecialeTabel
    {
        get => specialeTabelField; set => specialeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 64)]
    [System.Xml.Serialization.XmlArrayItem("SpecialeTilSpecialeInfo", IsNullable = false)]
    public SpecialeTilSpecialeInfoType[] SpecialeTilSpecialeTabel
    {
        get => specialeTilSpecialeTabelField; set => specialeTilSpecialeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 65)]
    [System.Xml.Serialization.XmlArrayItem("SkoleperiodeInfo", IsNullable = false)]
    public SkoleperiodeInfoType[] SkoleperiodeTabel
    {
        get => skoleperiodeTabelField; set => skoleperiodeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 66)]
    [System.Xml.Serialization.XmlArrayItem("StudieretHfOverbygFagInfo", IsNullable = false)]
    public StudieretHfOverbygFagInfoType[] StudieretHfOverbygFagTabel
    {
        get => studieretHfOverbygFagTabelField; set => studieretHfOverbygFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 67)]
    [System.Xml.Serialization.XmlArrayItem("TaelleperiodeInfo", IsNullable = false)]
    public TaelleperiodeInfoType[] TaelleperiodeTabel
    {
        get => taelleperiodeTabelField; set => taelleperiodeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 68)]
    [System.Xml.Serialization.XmlArrayItem("UddannelseAarsnormInfo", IsNullable = false)]
    public UddannelseAarsnormInfoType[] UddannelseAarsnormTabel
    {
        get => uddannelseAarsnormTabelField; set => uddannelseAarsnormTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 69)]
    [System.Xml.Serialization.XmlArrayItem("UddFrmSprogInfo", IsNullable = false)]
    public UddFrmSprogInfoType[] UddFrmSprogTabel
    {
        get => uddFrmSprogTabelField; set => uddFrmSprogTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 70)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeSpecialeInfo", IsNullable = false)]
    public ElevtypeSpecialeInfoType[] ElevtypeSpecialeTabel
    {
        get => elevtypeSpecialeTabelField; set => elevtypeSpecialeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 71)]
    [System.Xml.Serialization.XmlArrayItem("ElevtypeSkoleperiodeInfo", IsNullable = false)]
    public ElevtypeSkoleperiodeInfoType[] ElevtypeSkoleperiodeTabel
    {
        get => elevtypeSkoleperiodeTabelField; set => elevtypeSkoleperiodeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 72)]
    [System.Xml.Serialization.XmlArrayItem("TilskudsmaerkeTmkInfo", IsNullable = false)]
    public TilskudsmaerkeTmkInfoType[] TilskudsmaerkeTmkTabel
    {
        get => tilskudsmaerkeTmkTabelField; set => tilskudsmaerkeTmkTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 73)]
    [System.Xml.Serialization.XmlArrayItem("UddannelseProeveInfo", IsNullable = false)]
    public UddannelseProeveInfoType[] UddannelseProeveTabel
    {
        get => uddannelseProeveTabelField; set => uddannelseProeveTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 74)]
    [System.Xml.Serialization.XmlArrayItem("TmkSkoleperiodeInfo", IsNullable = false)]
    public TmkSkoleperiodeInfoType[] TmkSkoleperiodeTabel
    {
        get => tmkSkoleperiodeTabelField; set => tmkSkoleperiodeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 75)]
    [System.Xml.Serialization.XmlArrayItem("TmkAauInfo", IsNullable = false)]
    public TmkAauInfoType[] TmkAauTabel
    {
        get => tmkAauTabelField; set => tmkAauTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 76)]
    [System.Xml.Serialization.XmlArrayItem("FagTakstInfo", IsNullable = false)]
    public FagTakstInfoType[] FagTakstTabel
    {
        get => fagTakstTabelField; set => fagTakstTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 77)]
    [System.Xml.Serialization.XmlArrayItem("UddannelseTakstInfo", IsNullable = false)]
    public UddannelseTakstInfoType[] UddannelseTakstTabel
    {
        get => uddannelseTakstTabelField; set => uddannelseTakstTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 78)]
    [System.Xml.Serialization.XmlArrayItem("ResultatformInfo", IsNullable = false)]
    public ResultatformInfoType[] ResultatformTabel
    {
        get => resultatformTabelField; set => resultatformTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 79)]
    [System.Xml.Serialization.XmlArrayItem("ResultatformFagInfo", IsNullable = false)]
    public ResultatformFagInfoType[] ResultatformFagTabel
    {
        get => resultatformFagTabelField; set => resultatformFagTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 80)]
    [System.Xml.Serialization.XmlArrayItem("FagUddProeveInfo", IsNullable = false)]
    public FagUddProeveInfoType[] FagUddProeveTabel
    {
        get => fagUddProeveTabelField; set => fagUddProeveTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 81)]
    [System.Xml.Serialization.XmlArrayItem("FagSpecialeInfo", IsNullable = false)]
    public FagSpecialeInfoType[] FagSpecialeTabel
    {
        get => fagSpecialeTabelField; set => fagSpecialeTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 82)]
    [System.Xml.Serialization.XmlArrayItem("SuUddannelserInfo", IsNullable = false)]
    public SuUddannelserInfoType[] SuUddannelserTabel
    {
        get => suUddannelserTabelField; set => suUddannelserTabelField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 83)]
    [System.Xml.Serialization.XmlArrayItem("JurEnhedAeAfdelingInfo", IsNullable = false)]
    public JurEnhedAeAfdelingInfoType[] JurEnhedAeAfdelingTabel
    {
        get => jurEnhedAeAfdelingTabelField; set => jurEnhedAeAfdelingTabelField = value;
    }
}

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class FagUddInfoType
{

    private string fagUddIDField;

    private string uddannelseRefField;

    private string fagRefField;

    private DateTime gyldigFraField;

    private DateTime gyldigTilField;

    private bool gyldigTilFieldSpecified;

    private string uddannelseFagtypeField;

    private string elevtypeSamlingRefField;

    private string regelgrundlagRefField;

    private string gF1Field;

    private string gF2Field;

    private string hfField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string FagUddID
    {
        get => fagUddIDField; set => fagUddIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string UddannelseRef
    {
        get => uddannelseRefField; set => uddannelseRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
    public DateTime GyldigFra
    {
        get => gyldigFraField; set => gyldigFraField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 4)]
    public DateTime GyldigTil
    {
        get => gyldigTilField; set => gyldigTilField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool GyldigTilSpecified
    {
        get => gyldigTilFieldSpecified; set => gyldigTilFieldSpecified = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public string UddannelseFagtype
    {
        get => uddannelseFagtypeField; set => uddannelseFagtypeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 6)]
    public string ElevtypeSamlingRef
    {
        get => elevtypeSamlingRefField; set => elevtypeSamlingRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 7)]
    public string RegelgrundlagRef
    {
        get => regelgrundlagRefField; set => regelgrundlagRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public string GF1
    {
        get => gF1Field; set => gF1Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 9)]
    public string GF2
    {
        get => gF2Field; set => gF2Field = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 10)]
    public string HF
    {
        get => hfField; set => hfField = value;
    }
}

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class StudieretHfOverbygFagInfoType
{

    private string studieretHfOverbygFagIDField;

    private string studieretHfOverbygRefField;

    private string fagRefField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string StudieretHfOverbygFagID
    {
        get => studieretHfOverbygFagIDField; set => studieretHfOverbygFagIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string StudieretHfOverbygRef
    {
        get => studieretHfOverbygRefField; set => studieretHfOverbygRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 2)]
    public string FagRef
    {
        get => fagRefField; set => fagRefField = value;
    }
}

[Serializable]
[System.Diagnostics.DebuggerStepThrough]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(Namespace = "http://xprs.dk/2005/08/17/")]
public class TaelleperiodeInfoType
{

    private string taelleperiodeIDField;

    private string skoleperiodeRefField;

    private int taelleperiodeField;

    private string relativTaelledagField;

    private decimal varighedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 0)]
    public string TaelleperiodeID
    {
        get => taelleperiodeIDField; set => taelleperiodeIDField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "positiveInteger", Order = 1)]
    public string SkoleperiodeRef
    {
        get => skoleperiodeRefField; set => skoleperiodeRefField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public int Taelleperiode
    {
        get => taelleperiodeField; set => taelleperiodeField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "integer", Order = 3)]
    public string RelativTaelledag
    {
        get => relativTaelledagField; set => relativTaelledagField = value;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public decimal Varighed
    {
        get => varighedField; set => varighedField = value;
    }
}
