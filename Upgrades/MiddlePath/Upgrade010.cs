﻿namespace TemplateMonkey.Upgrades.MiddlePath
{
    public class Upgrade010 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 1;
        public override int Cost => 0;
        public override string DisplayName => "010DisplayName";
        public override string Description => "010Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}