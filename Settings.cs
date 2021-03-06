using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Dropdown;
using MCM.Abstractions.Settings.Base.Global;

namespace UnlimitLord
{
    internal sealed partial class Settings : AttributeGlobalSettings<Settings>
    {
        public override string Id => "UnlimitLord.Settings_v2";
        public override string DisplayName => "UnlimitLord " + typeof(Settings).Assembly.GetName().Version.ToString(3);
        public override string FolderName => "UnlimitLord";
        public override string FormatType => "json";
    }

    // Movement speed settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=D78DVfmutxZX}Movement Speed")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool MovementSpeedEnabled { get; set; } = false;

        [SettingPropertyGroup("{=D78DVfmutxZX}Movement Speed")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> MovementSpeedAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerParty,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=D78DVfmutxZX}Movement Speed")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 10000f, Order = 1,
            RequireRestart = false)]
        public float MovementSpeedMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=D78DVfmutxZX}Movement Speed")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0.01f, 100000f, Order = 2, RequireRestart = false)]
        public float MinimumMovementSpeed { get; set; } = 1f;

        [SettingPropertyGroup("{=D78DVfmutxZX}Movement Speed")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0.01f, 100000f, Order = 3, RequireRestart = false)]
        public float MaximumMovementSpeed { get; set; } = 100000f;
    }

    // Troop healing rate settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=hHROV0BkMDfG}Troop Healing Rate")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool TroopHealingRateEnabled { get; set; } = false;

        [SettingPropertyGroup("{=hHROV0BkMDfG}Troop Healing Rate")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> TroopHealingRateAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerParty,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=hHROV0BkMDfG}Troop Healing Rate")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float TroopHealingRateMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=hHROV0BkMDfG}Troop Healing Rate")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0f, 100000f, Order = 2, RequireRestart = false)]
        public float MinimumTroopHealingRate { get; set; } = 0f;

        [SettingPropertyGroup("{=hHROV0BkMDfG}Troop Healing Rate")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0f, 100000f, Order = 3, RequireRestart = false)]
        public float MaximumTroopHealingRate { get; set; } = 100000f;
    }

    // Hero healing rate settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=uvIPiQqsx5Qb}Hero Healing Rate")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool HeroHealingRateEnabled { get; set; } = false;

        [SettingPropertyGroup("{=uvIPiQqsx5Qb}Hero Healing Rate")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> HeroHealingRateAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerParty,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=uvIPiQqsx5Qb}Hero Healing Rate")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float HeroHealingRateMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=uvIPiQqsx5Qb}Hero Healing Rate")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0f, 100000f, Order = 2, RequireRestart = false)]
        public float MinimumHeroHealingRate { get; set; } = 0f;

        [SettingPropertyGroup("{=uvIPiQqsx5Qb}Hero Healing Rate")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0f, 100000f, Order = 3, RequireRestart = false)]
        public float MaximumHeroHealingRate { get; set; } = 100000f;
    }

    // Morale settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=DB1kpsmAAIky}Morale")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool MoraleEnabled { get; set; } = false;

        [SettingPropertyGroup("{=DB1kpsmAAIky}Morale")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> MoraleAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerParty,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=DB1kpsmAAIky}Morale")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 20f, Order = 1, RequireRestart = false)]
        public float MoraleMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=DB1kpsmAAIky}Morale")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0f, 100f, Order = 2, RequireRestart = false)]
        public float MinimumMorale { get; set; } = 5f;

        [SettingPropertyGroup("{=DB1kpsmAAIky}Morale")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0f, 100f, Order = 3, RequireRestart = false)]
        public float MaximumMorale { get; set; } = 100f;
    }

    // Castle garrison size settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=SrBxpWv16oRJ}Castle Garrison Size")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool CastleGarrisonSizeEnabled { get; set; } = false;

        [SettingPropertyGroup("{=SrBxpWv16oRJ}Castle Garrison Size")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> CastleGarrisonSizeAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=SrBxpWv16oRJ}Castle Garrison Size")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float CastleGarrisonSizeMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=SrBxpWv16oRJ}Castle Garrison Size")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 100000, Order = 2, RequireRestart = false)]
        public int MinimumCastleGarrisonSize { get; set; } = 25;

        [SettingPropertyGroup("{=SrBxpWv16oRJ}Castle Garrison Size")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 100000, Order = 3, RequireRestart = false)]
        public int MaximumCastleGarrisonSize { get; set; } = 100000;
    }

    // Town garrison size settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=9hYB9kzrN9Qs}Town Garrison Size")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool TownGarrisonSizeEnabled { get; set; } = false;

        [SettingPropertyGroup("{=9hYB9kzrN9Qs}Town Garrison Size")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> TownGarrisonSizeAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=9hYB9kzrN9Qs}Town Garrison Size")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float TownGarrisonSizeMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=9hYB9kzrN9Qs}Town Garrison Size")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 100000, Order = 2, RequireRestart = false)]
        public int MinimumTownGarrisonSize { get; set; } = 25;

        [SettingPropertyGroup("{=9hYB9kzrN9Qs}Town Garrison Size")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 100000, Order = 3, RequireRestart = false)]
        public int MaximumTownGarrisonSize { get; set; } = 100000;
    }

    // Caravan size settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=Fn3jRf9vQr7c}Caravan Size")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool CaravanSizeEnabled { get; set; } = false;

        [SettingPropertyGroup("{=Fn3jRf9vQr7c}Caravan Size")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> CaravanSizeAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=Fn3jRf9vQr7c}Caravan Size")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float CaravanSizeMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=Fn3jRf9vQr7c}Caravan Size")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 100000, Order = 2, RequireRestart = false)]
        public int MinimumCaravanSize { get; set; } = 10;

        [SettingPropertyGroup("{=Fn3jRf9vQr7c}Caravan Size")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 100000, Order = 3, RequireRestart = false)]
        public int MaximumCaravanSize { get; set; } = 100000;
    }

    // Party wage settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=ibM41IqxC0Vq}Party Wages")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool PartyWageEnabled { get; set; } = false;

        [SettingPropertyGroup("{=ibM41IqxC0Vq}Party Wages")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> PartyWageAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=ibM41IqxC0Vq}Party Wages")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 5000f, Order = 1, RequireRestart = false)]
        public float PartyWageMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=ibM41IqxC0Vq}Party Wages")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 500000, Order = 2, RequireRestart = false)]
        public int MinimumPartyWage { get; set; } = 0;

        [SettingPropertyGroup("{=ibM41IqxC0Vq}Party Wages")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 500000, Order = 3, RequireRestart = false)]
        public int MaximumPartyWage { get; set; } = 500000;
    }

    // Garrison wage settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=tVYKb9VGO56w}Garrison Wages")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool GarrisonWageEnabled { get; set; } = false;

        [SettingPropertyGroup("{=tVYKb9VGO56w}Garrison Wages")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> GarrisonWageAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=tVYKb9VGO56w}Garrison Wages")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 5000f, Order = 1, RequireRestart = false)]
        public float GarrisonWageMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=tVYKb9VGO56w}Garrison Wages")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 500000, Order = 2, RequireRestart = false)]
        public int MinimumGarrisonWage { get; set; } = 0;

        [SettingPropertyGroup("{=tVYKb9VGO56w}Garrison Wages")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 500000, Order = 3, RequireRestart = false)]
        public int MaximumGarrisonWage { get; set; } = 500000;
    }

    // Number of parties settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=oP25rddkklhH}Number of Parties")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool PartyAmountEnabled { get; set; } = false;

        [SettingPropertyGroup("{=oP25rddkklhH}Number of Parties")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> PartyAmountAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=oP25rddkklhH}Number of Parties")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 500f, Order = 1, RequireRestart = false)]
        public float PartyAmountMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=oP25rddkklhH}Number of Parties")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 2500, Order = 2, RequireRestart = false)]
        public int MinimumPartyAmount { get; set; } = 1;

        [SettingPropertyGroup("{=oP25rddkklhH}Number of Parties")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 2500, Order = 3, RequireRestart = false)]
        public int MaximumPartyAmount { get; set; } = 2500;
    }

    // Number of companions settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=H540pvwooRpm}Number of Companions")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool CompanionAmountEnabled { get; set; } = false;

        [SettingPropertyGroup("{=H540pvwooRpm}Number of Companions")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 500f, Order = 1, RequireRestart = false)]
        public float CompanionAmountMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=H540pvwooRpm}Number of Companions")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 2500, Order = 2, RequireRestart = false)]
        public int MinimumCompanionAmount { get; set; } = 1;

        [SettingPropertyGroup("{=H540pvwooRpm}Number of Companions")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 2500, Order = 3, RequireRestart = false)]
        public int MaximumCompanionAmount { get; set; } = 2500;
    }

    // Crafting stamina settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=pQH0InUHZa2K}Crafting Stamina")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> CraftingStaminaAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerOnly,
            AppliesToEnum.PlayerCompanions
        }, 0);

        [SettingPropertyGroup("{=pQH0InUHZa2K}Crafting Stamina")]
        [SettingPropertyBool("{=hNX8v28ZXvze}Infinite", Order = 1, RequireRestart = false)]
        public bool InfiniteCraftingStaminaEnabled { get; set; } = false;
    }

    // Number of workshops settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=jgc6D8GTmLHr}Number of Workshops")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool WorkshopAmountEnabled { get; set; } = false;

        [SettingPropertyGroup("{=jgc6D8GTmLHr}Number of Workshops")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 100f, Order = 1, RequireRestart = false)]
        public float WorkshopAmountMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=jgc6D8GTmLHr}Number of Workshops")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 500, Order = 2, RequireRestart = false)]
        public int MinimumWorkshopAmount { get; set; } = 1;

        [SettingPropertyGroup("{=jgc6D8GTmLHr}Number of Workshops")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 500, Order = 3, RequireRestart = false)]
        public int MaximumWorkshopAmount { get; set; } = 500;
    }

    // Hero health amount settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=k7zNutD2MZWa}Hero Health Amount")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool HeroHealthAmountEnabled { get; set; } = false;

        [SettingPropertyGroup("{=k7zNutD2MZWa}Hero Health Amount")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> HeroHealthAmountAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerOnly,
            AppliesToEnum.PlayerCompanions,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=k7zNutD2MZWa}Hero Health Amount")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float HeroHealthAmountMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=k7zNutD2MZWa}Hero Health Amount")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 100000, Order = 2, RequireRestart = false)]
        public int MinimumHeroHealthAmount { get; set; } = 50;

        [SettingPropertyGroup("{=k7zNutD2MZWa}Hero Health Amount")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 100000, Order = 3, RequireRestart = false)]
        public int MaximumHeroHealthAmount { get; set; } = 100000;
    }

    // Party food consumption settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=MBgE3OOCyUw0}Party Food Consumption")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool PartyFoodConsumptionEnabled { get; set; } = false;

        [SettingPropertyGroup("{=MBgE3OOCyUw0}Party Food Consumption")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> PartyFoodConsumptionAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerParty,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=MBgE3OOCyUw0}Party Food Consumption")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float PartyFoodConsumptionMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=MBgE3OOCyUw0}Party Food Consumption")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0f, 100000f, Order = 2, RequireRestart = false)]
        public float MinimumPartyFoodConsumption { get; set; } = 0f;

        [SettingPropertyGroup("{=MBgE3OOCyUw0}Party Food Consumption")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0f, 100000f, Order = 3, RequireRestart = false)]
        public float MaximumPartyFoodConsumption { get; set; } = 100000f;
    }

    // Maximum party troops settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=hBEXh7AijM7I}Maximum Party Troops")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool PartyTroopAmountEnabled { get; set; } = false;

        [SettingPropertyGroup("{=hBEXh7AijM7I}Maximum Party Troops")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> PartyTroopAmountAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerParty,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=hBEXh7AijM7I}Maximum Party Troops")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 1000f, Order = 1, RequireRestart = false)]
        public float PartyTroopAmountMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=hBEXh7AijM7I}Maximum Party Troops")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 100000, Order = 2, RequireRestart = false)]
        public int MinimumPartyTroopAmount { get; set; } = 10;

        [SettingPropertyGroup("{=hBEXh7AijM7I}Maximum Party Troops")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 100000, Order = 3, RequireRestart = false)]
        public int MaximumPartyTroopAmount { get; set; } = 100000;
    }

    // Maximum party prisoners settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=PTj8sDnBew21}Maximum Party Prisoners")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool PartyPrisonerAmountEnabled { get; set; } = false;

        [SettingPropertyGroup("{=PTj8sDnBew21}Maximum Party Prisoners")]
        [SettingPropertyDropdown("{=Jn6KV7vNzCVC}Who is affected", Order = 0, RequireRestart = false)]
        public DropdownDefault<AppliesToEnum> PartyPrisonerAmountAppliesTo { get; set; } = new DropdownDefault<AppliesToEnum>(new[]
        {
            AppliesToEnum.PlayerParty,
            AppliesToEnum.PlayerClan,
            AppliesToEnum.PlayerArmy,
            AppliesToEnum.PlayerKingdom,
            AppliesToEnum.Everyone
        }, 0);

        [SettingPropertyGroup("{=PTj8sDnBew21}Maximum Party Prisoners")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 500f, Order = 1, RequireRestart = false)]
        public float PartyPrisonerAmountMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=PTj8sDnBew21}Maximum Party Prisoners")]
        [SettingPropertyInteger("{=RkptUH9teOPo}Minimum", 0, 50000, Order = 2, RequireRestart = false)]
        public int MinimumPartyPrisonerAmount { get; set; } = 5;

        [SettingPropertyGroup("{=PTj8sDnBew21}Maximum Party Prisoners")]
        [SettingPropertyInteger("{=3YOggkouIghy}Maximum", 0, 50000, Order = 3, RequireRestart = false)]
        public int MaximumPartyPrisonerAmount { get; set; } = 50000;
    }

    // Persuasion chance settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=mEIXrv2G7tCv}Persuasion Chance")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool PersuasionChanceEnabled { get; set; } = false;

        [SettingPropertyGroup("{=mEIXrv2G7tCv}Persuasion Chance")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 10f, Order = 0, RequireRestart = false)]
        public float PersuasionSuccessMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=mEIXrv2G7tCv}Persuasion Chance")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0f, 1f, "P", Order = 1, RequireRestart = false)]
        public float MinimumSuccessChance { get; set; } = 0f;

        [SettingPropertyGroup("{=mEIXrv2G7tCv}Persuasion Chance")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0f, 1f, "P", Order = 2, RequireRestart = false)]
        public float MaximumSuccessChance { get; set; } = 1f;

        [SettingPropertyGroup("{=mEIXrv2G7tCv}Persuasion Chance")]
        [SettingPropertyFloatingInteger("{=NVJNs9zD1d9t}Critical Success Ratio", 0f, 1f, "P", Order = 3, RequireRestart = false)]
        public float CriticalSuccessChance { get; set; } = 0.33f;

        [SettingPropertyGroup("{=mEIXrv2G7tCv}Persuasion Chance")]
        [SettingPropertyFloatingInteger("{=kwRxutt05AYT}Critical Failure Ratio", 0f, 1f, "P", Order = 4, RequireRestart = false)]
        public float CriticalFailureChance { get; set; } = 0.33f;
    }

    // Barter acceptance settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=vPepJOx8OW1k}Bartering")]
        [SettingPropertyBool("{=bK6jMmtByOF2}Barter Always Accepted", Order = 0, RequireRestart = false)]
        public bool BarterAlwaysAccepted { get; set; } = false;

        [SettingPropertyGroup("{=vPepJOx8OW1k}Bartering")]
        [SettingPropertyBool("{=0IMbmCXRtEPk}Enable Barter Item Value Multiplier", Order = 1, RequireRestart = false)]
        public bool BarterSuccessMultiplierEnabled { get; set; } = false;

        [SettingPropertyGroup("{=vPepJOx8OW1k}Bartering")]
        [SettingPropertyFloatingInteger("{=Iz3Nk98BIiOO}Player Item Value Multiplier", 0.01f, 1000f, Order = 2, RequireRestart = false)]
        public float BarterSuccessMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=vPepJOx8OW1k}Bartering")]
        [SettingPropertyBool("{=a64AJwEQvEde}Set Cooldown", Order = 3, RequireRestart = false)]
        public bool BarterCooldownEnabled { get; set; } = false;

        [SettingPropertyGroup("{=vPepJOx8OW1k}Bartering")]
        [SettingPropertyInteger("{=q3KigaRis8Ny}Cooldown Days", 0, 120, Order = 4, RequireRestart = false)]
        public int BarterCooldownDays { get; set; } = 3;
    }

    // Disguise chance settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=FAz1UWhX6HOt}Disguise Chance")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool DisguiseChanceEnabled { get; set; } = false;

        [SettingPropertyGroup("{=FAz1UWhX6HOt}Disguise Chance")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 25f, Order = 1, RequireRestart = false)]
        public float DisguiseChanceMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=FAz1UWhX6HOt}Disguise Chance")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0f, 1f, "P", Order = 2, RequireRestart = false)]
        public float MinimumDisguiseChance { get; set; } = 0f;

        [SettingPropertyGroup("{=FAz1UWhX6HOt}Disguise Chance")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0f, 1f, "P", Order = 3, RequireRestart = false)]
        public float MaximumDisguiseChance { get; set; } = 1f;
    }

    // View distance settings
    internal sealed partial class Settings
    {
        [SettingPropertyGroup("{=Mb5ywYiZva1Y}View Distance")]
        [SettingPropertyBool("{=QdjFJY1jTXY2}Enabled", RequireRestart = false)]
        public bool ViewDistanceEnabled { get; set; } = false;

        [SettingPropertyGroup("{=Mb5ywYiZva1Y}View Distance")]
        [SettingPropertyFloatingInteger("{=CCmuVoB3sOUO}Multiplier", 0.01f, 50f, Order = 1, RequireRestart = false)]
        public float ViewDistanceMultiplier { get; set; } = 1f;

        [SettingPropertyGroup("{=Mb5ywYiZva1Y}View Distance")]
        [SettingPropertyFloatingInteger("{=RkptUH9teOPo}Minimum", 0f, 500f, Order = 2, RequireRestart = false)]
        public float MinimumViewDistance { get; set; } = 5f;

        [SettingPropertyGroup("{=Mb5ywYiZva1Y}View Distance")]
        [SettingPropertyFloatingInteger("{=3YOggkouIghy}Maximum", 0f, 500f, Order = 3, RequireRestart = false)]
        public float MaximumViewDistance { get; set; } = 75f;
    }
}