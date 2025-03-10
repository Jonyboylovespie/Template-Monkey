namespace TemplateMonkey.Upgrades.BottomPath
{
    public class Upgrade003 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 3;
        public override int Cost => 0;
        public override string DisplayName => "003DisplayName";
        public override string Description => "003Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}
