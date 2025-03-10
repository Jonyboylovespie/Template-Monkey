namespace TemplateMonkey.Upgrades.TopPath
{
    public class Upgrade400 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 4;
        public override int Cost => 0;
        public override string DisplayName => "400DisplayName";
        public override string Description => "400Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}
