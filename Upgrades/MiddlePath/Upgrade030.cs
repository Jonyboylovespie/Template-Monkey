namespace TemplateMonkey.Upgrades.MiddlePath
{
    public class Upgrade030 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 3;
        public override int Cost => 0;
        public override string DisplayName => "030DisplayName";
        public override string Description => "030Description";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            // Code here
        }
    }
}