namespace TemplateMonkey
{
    public class TemplateMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Primary;
        public override string BaseTower => TowerType.DartMonkey;
        public override int Cost => 0;
        public override int TopPathUpgrades => 5;
        public override int MiddlePathUpgrades => 5;
        public override int BottomPathUpgrades => 5;
        public override string Description => "";
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            
        }
        public override bool IsValidCrosspath(int[] tiers) =>
            ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);
    }
}