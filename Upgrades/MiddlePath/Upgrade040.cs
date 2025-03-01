namespace TemplateMonkey.Upgrades.MiddlePath
{
    public class Upgrade040 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 4;
        public override int Cost => 0;
        public override string DisplayName => "";
        public override string Description => "";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            
        }
    }
}