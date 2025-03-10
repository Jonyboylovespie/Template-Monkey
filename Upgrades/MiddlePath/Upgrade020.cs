namespace TemplateMonkey.Upgrades.MiddlePath
{
    public class Upgrade020 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 2;
        public override int Cost => 0;
        public override string DisplayName => "020DisplayName";
        public override string Description => "020Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}
