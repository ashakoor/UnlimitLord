/*
   Copyright (C) 2020 ashakoor

   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the
   License or any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program. If not, see <https://www.gnu.org/licenses/>.
*/

using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace UnlimitLord
{
    internal static class Helpers
    {
        public static float Clamp(float value, float min, float max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        public static float ClampAndExplain(float toClamp, StatExplainer explainer, float min, float max)
        {
            var baseTextObject = new TextObject("Total After UL Multiplier");
            var unLimitTextObject = new TextObject("UnlimitLord Clamp");
            var explainedNumber = new ExplainedNumber(toClamp, explainer, baseTextObject);

            explainedNumber.Add(Clamp(toClamp, min, max) - toClamp, unLimitTextObject);
            return explainedNumber.ResultNumber;
        }
    }
}