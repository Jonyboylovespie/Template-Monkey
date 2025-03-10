namespace TemplateMonkey.Upgrades.BottomPath
{
    public class Upgrade001 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 1;
        public override int Cost => 0;
        public override string DisplayName => "001DisplayName";
        public override string Description => "001Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}
