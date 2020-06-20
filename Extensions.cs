﻿/*
 Copyright (C) 2020 ashakoor

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License,
 or any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System.Linq;
using TaleWorlds.CampaignSystem;

namespace UnlimitLord
{
    // For TaleWorlds.CampaignSystem.Hero
    internal static partial class Extensions
    {
        public static bool IsThisHeroPlayerHero(this Hero hero)
        {
            return hero == Hero.MainHero;
        }

        public static bool IsThisHeroPlayerCompanion(this Hero hero)
        {
            return hero?.IsPlayerCompanion == true;
        }

        public static bool IsThisHeroInPlayerClan(this Hero hero)
        {
            return hero?.Clan?.IsPlayerLeadingThisClan() == true;
        }

        public static bool IsThisHeroInPlayerArmy(this Hero hero)
        {
            return hero?.PartyBelongedTo?.Army?.IsPlayerInThisArmy() == true;
        }

        public static bool IsThisHeroInPlayerKingdom(this Hero hero)
        {
            return hero?.Clan?.Kingdom?.IsPlayerInThisKingdom() == true;
        }
    }

    // For TaleWorlds.CampaignSystem.PartyBase
    internal static partial class Extensions
    {
        public static bool IsPlayerLeadingThisParty(this PartyBase partyBase)
        {
            return partyBase?.LeaderHero?.IsThisHeroPlayerHero() == true;
        }

        public static bool IsThisPartyInPlayerClan(this PartyBase partyBase)
        {
            return partyBase?.LeaderHero?.Clan?.IsPlayerLeadingThisClan() == true;
        }

        public static bool IsThisPartyInPlayerArmy(this PartyBase partyBase)
        {
            return partyBase?.MobileParty?.IsThisPartyInPlayerArmy() == true;
        }

        public static bool IsThisPartyInPlayerKingdom(this PartyBase partyBase)
        {
            return partyBase?.LeaderHero?.Clan?.Kingdom?.IsPlayerInThisKingdom() == true;
        }

        public static bool IsThisPartyGarrison(this PartyBase party)
        {
            return party?.MobileParty?.IsGarrison() == true;
        }

        public static bool IsPartyOwnedByPlayer(this PartyBase party)
        {
            return party?.Owner?.IsThisHeroPlayerHero() == true;
        }

        public static bool DoesPartyBelongToCastle(this PartyBase party)
        {
            return party?.MobileParty?.DoesPartyBelongToCastle() == true;
        }

        public static bool DoesPartyBelongToTown(this PartyBase party)
        {
            return party?.MobileParty?.DoesPartyBelongToTown() == true;
        }
    }

    // For TaleWorlds.CampaignSystem.MobileParty
    internal static partial class Extensions
    {
        public static bool IsPlayerLeadingThisParty(this MobileParty mobileParty)
        {
            return mobileParty?.LeaderHero?.IsThisHeroPlayerHero() == true;
        }

        public static bool IsThisPartyInPlayerClan(this MobileParty mobileParty)
        {
            return mobileParty?.LeaderHero?.Clan?.IsPlayerLeadingThisClan() == true;
        }

        public static bool IsThisPartyInPlayerArmy(this MobileParty mobileParty)
        {
            return mobileParty?.Army?.IsPlayerInThisArmy() == true;
        }

        public static bool IsThisPartyInPlayerKingdom(this MobileParty mobileParty)
        {
            return mobileParty?.LeaderHero?.Clan?.Kingdom?.IsPlayerInThisKingdom() == true;
        }

        public static bool IsGarrison(this MobileParty party)
        {
            return party?.IsGarrison == true;
        }

        public static bool IsPartyOwnedByPlayer(this MobileParty party)
        {
            return party?.Party?.IsPartyOwnedByPlayer() == true;
        }

        public static bool DoesPartyBelongToCastle(this MobileParty party)
        {
            return party?.HomeSettlement?.IsCastle == true;
        }

        public static bool DoesPartyBelongToTown(this MobileParty party)
        {
            return party?.HomeSettlement?.IsTown == true;
        }
    }

    // For TaleWorlds.CampaignSystem.Clan
    internal static partial class Extensions
    {
        public static bool IsPlayerLeadingThisClan(this Clan clan)
        {
            return clan?.Leader?.IsThisHeroPlayerHero() == true;
        }

        public static bool IsThisClanInPlayerKingdom(this Clan clan)
        {
            return clan?.Kingdom?.IsPlayerInThisKingdom() == true;
        }
    }

    // For TaleWorlds.CampaignSystem.Army
    internal static partial class Extensions
    {
        public static bool IsPlayerInThisArmy(this Army army)
        {
            return army?.Parties?.Contains(MobileParty.MainParty) == true;
        }

        public static bool IsPlayerLeadingThisArmy(this Army army)
        {
            return army?.LeaderParty?.LeaderHero?.IsThisHeroPlayerHero() == true;
        }

        public static bool IsThisArmyInPlayerKingdom(this Army army)
        {
            return army?.Kingdom?.IsPlayerInThisKingdom() == true;
        }
    }

    // For TaleWorlds.CampaignSystem.Kingdom
    internal static partial class Extensions
    {
        public static bool IsPlayerInThisKingdom(this Kingdom kingdom)
        {
            return kingdom?.Heroes?.Contains(Hero.MainHero) == true;
        }

        public static bool IsPlayerRulingThisKingdom(this Kingdom kingdom)
        {
            return kingdom?.Leader?.IsThisHeroPlayerHero() == true;
        }
    }
}