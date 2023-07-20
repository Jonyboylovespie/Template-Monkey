using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace TemplateMonkey.Upgrades.TopPath
{
    public class Upgrade400 : ModUpgrade<TemplateMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 4;
        public override int Cost => 0;
        public override string DisplayName => "";
        public override string Description => "";
        public override string Portrait => "";
        public override void ApplyUpgrade(TowerModel tower)
        {
            
        }
    }
}
