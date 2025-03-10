namespace TemplateMonkey.Upgrades.BottomPath
{
    public class Upgrade004 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 4;
        public override int Cost => 0;
        public override string DisplayName => "004DisplayName";
        public override string Description => "004Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}
