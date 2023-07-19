﻿using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace TemplateMonkey.Upgrades.TopPath
{
    public class Upgrade500 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 5;
        public override int Cost => 0;
        public override string Description => "";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            
        }
    }
}