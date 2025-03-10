namespace TemplateMonkey.Upgrades.TopPath
{
    public class Upgrade300 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 3;
        public override int Cost => 0;
        public override string DisplayName => "300DisplayName";
        public override string Description => "300Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}