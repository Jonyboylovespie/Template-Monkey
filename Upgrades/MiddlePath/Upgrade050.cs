namespace TemplateMonkey.Upgrades.MiddlePath
{
    public class Upgrade050 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 5;
        public override int Cost => 0;
        public override string DisplayName => "050DisplayName";
        public override string Description => "050Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}