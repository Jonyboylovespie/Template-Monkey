namespace TemplateMonkey.Upgrades.TopPath
{
    public class Upgrade200 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 2;
        public override int Cost => 0;
        public override string DisplayName => "200DisplayName";
        public override string Description => "200Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}