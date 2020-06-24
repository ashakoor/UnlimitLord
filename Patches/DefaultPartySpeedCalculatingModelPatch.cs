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

using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;

namespace UnlimitLord.Patches
{
    [HarmonyPatch(typeof(DefaultPartySpeedCalculatingModel), "CalculateFinalSpeed")]
    internal static class DefaultPartySpeedCalculatingModelPatch
    {
        public static Settings Setting => Settings.Instance;
        public static bool Enabled => Setting.MovementSpeedEnabled;
        public static AppliesToEnum AppliesTo => Setting.MovementSpeedAppliesTo.SelectedValue.GetWho();
        public static float Multiplier => Setting.MovementSpeedMultiplier;
        public static float Minimum => Setting.MinimumMovementSpeed;
        public static float Maximum => Setting.MaximumMovementSpeed;

        internal static float Postfix(float result, MobileParty mobileParty, StatExplainer explanation)
        {
            if (!PatchAppliesTo.DoesPatchApply(AppliesTo, mobileParty))
                return result;

            return Math.ClampAndExplainFloat(result * Multiplier, explanation, Minimum, Maximum);
        }

        internal static bool Prepare()
        {
            return Enabled;
        }
    }
}