public class GameModel
{
    // Fields
    [FieldOffset(Offset="0x8")]
    public readonly BalanceType BalanceType;
    [FieldOffset(Offset="0xC")]
    public string LteId;
    [FieldOffset(Offset="0x10")]
    public DateTimeOffset PreviousLoadTime;
    [FieldOffset(Offset="0x20")]
    public DateTimeOffset LoadTime;
    [FieldOffset(Offset="0x30")]
    public DateTimeOffset SaveTime;
    [FieldOffset(Offset="0x40")]
    public ushort DataVersion;
    [FieldOffset(Offset="0x44")]
    public uint SaveVersion;
    [FieldOffset(Offset="0x48")]
    public uint SharedSaveVersion;
    [FieldOffset(Offset="0x4C")]
    public readonly ReactiveProperty<float> MusicVolume;
    [FieldOffset(Offset="0x50")]
    public readonly ReactiveProperty<float> SfxVolume;
    [FieldOffset(Offset="0x54")]
    public readonly ReactiveProperty<bool> LowQuality;
    [FieldOffset(Offset="0x58")]
    public readonly ReactiveProperty<bool> BatterySaver;
    [FieldOffset(Offset="0x5C")]
    public readonly ReactiveProperty<bool> PhoneVibrate;
    [FieldOffset(Offset="0x60")]
    public string TutorialCheckpoint;
    [FieldOffset(Offset="0x64")]
    public readonly ReactiveCollection<string> CompletedTutorials;
    [FieldOffset(Offset="0x68")]
    public readonly ResourceOnHandMap Resources;
    [FieldOffset(Offset="0x6C")]
    public readonly IndustryCollection Industries;
    [FieldOffset(Offset="0x70")]
    public readonly MissionCollection Missions;
    [FieldOffset(Offset="0x74")]
    public ExperimentCollection ExperimentCollection;
    [FieldOffset(Offset="0x78")]
    public readonly AdCollection Ads;
    [FieldOffset(Offset="0x7C")]
    public StatisticMap Stats;
    [FieldOffset(Offset="0x80")]
    public readonly ReactiveDictionary<string, byte> Flags;
    [FieldOffset(Offset="0x84")]
    public readonly GeneratorCollection GeneratorCollection;
    [FieldOffset(Offset="0x88")]
    public readonly Dictionary<Resources.ResourceModel, GeneratorModel> GeneratorMap;
    [FieldOffset(Offset="0x8C")]
    public readonly ReactiveProperty<Gender> Gender;
    [FieldOffset(Offset="0x90")]
    public readonly ReactiveProperty<RankModel> Rank;
    [FieldOffset(Offset="0x98")]
    public DateTimeOffset ViewedNewsTime;
    [FieldOffset(Offset="0xA8")]
    public DateTimeOffset SpecialOfferBadgeResetTime;
    [FieldOffset(Offset="0xB8")]
    public readonly HashSet<string> PurchasedLimitedTimeBundles;
    [FieldOffset(Offset="0xBC")]
    public readonly ReactiveCollection<OfferModel> Offers;
    [FieldOffset(Offset="0xC0")]
    public readonly ReactiveProperty<int> BuyModifierIndex;
    [FieldOffset(Offset="0xC4")]
    public readonly ResearcherCollection ResearcherCollection;
    [FieldOffset(Offset="0xC8")]
    public readonly Dictionary<string, object> SessionData;
    [FieldOffset(Offset="0xCC")]
    public readonly Dictionary<string, float> IndustryScrollPositions;
    [FieldOffset(Offset="0xD0")]
    public readonly TradeCollection TradeCollection;
    [FieldOffset(Offset="0xD4")]
    public readonly DailyDealsCollection DailyDealsCollection;
    [FieldOffset(Offset="0xD8")]
    public readonly Dictionary<string, int> GachaScriptProgress;
    [FieldOffset(Offset="0xDC")]
    public readonly AirDropServiceProgressModel AirDropServiceProgressModel;
    [FieldOffset(Offset="0xE0")]
    public readonly LteProgressCollection LteProgressCollection;
    [FieldOffset(Offset="0xE4")]
    public readonly ReactiveProperty<PendingLeaderboardScore> FailedLeaderboardScore;
    [FieldOffset(Offset="0xE8")]
    public int LatestBracketPlacementIndex;
    [FieldOffset(Offset="0xEC")]
    public readonly ReactiveProperty<int> AvailableFreeGachaCapsules;
    [FieldOffset(Offset="0xF0")]
    public readonly ReactiveProperty<double> NextFreeGachaTimeRemaining;
    [FieldOffset(Offset="0xF4")]
    public string LastEarnedSupremeId;
    [FieldOffset(Offset="0xF8")]
    public readonly List<string> AbTestGroups;
    [FieldOffset(Offset="0xFC")]
    public readonly List<PurchaseHistoryService.PurchaseHistoryItem> PurchaseHistory;
    [FieldOffset(Offset="0x100")]
    public readonly List<OfferPoolData> OfferPoolIndices;
    [FieldOffset(Offset="0x104")]
    public readonly List<OfferResetData> OfferResetData;

    // Methods
    [Address(RVA="0xB6BA30", Offset="0xB6BA30")]
    public GameModel();
    [Address(RVA="0xB6BA38", Offset="0xB6BA38")]
    public GameModel(BalanceType balanceType);
}
