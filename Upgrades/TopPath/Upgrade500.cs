﻿namespace TemplateMonkey.Upgrades.TopPath
{
    public class Upgrade500 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 5;
        public override int Cost => 0;
        public override string DisplayName => "500DisplayName";
        public override string Description => "500Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}
