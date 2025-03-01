namespace TemplateMonkey.Upgrades.BottomPath
{
    public class Upgrade002 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 2;
        public override int Cost => 0;
        public override string DisplayName => "";
        public override string Description => "";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            
        }
    }
}