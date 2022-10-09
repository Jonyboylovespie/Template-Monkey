using Assets.Scripts.Models;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Assets.Scripts.Models.Towers.Filters;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.TowerFilters;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Models.TowerSets;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Display;
using Assets.Scripts.Utils;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Harmony;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using TemplateMonkey;
using UnhollowerBaseLib;

[assembly: MelonInfo(typeof(TemplateMonkey.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TemplateMonkey
{
    internal class Main : BloonsMod
    {
        public class TemplateMonkey : ModTower
        {
            public override string Name => nameof(TemplateMonkey);

            public override string DisplayName => "Template Monkey";

            public override string Description => "";

            public override string BaseTower => "DartMonkey";

            public override int Cost => 0;

            public override int TopPathUpgrades => 5;

            public override int MiddlePathUpgrades => 5;

            public override int BottomPathUpgrades => 5;

            public override ParagonMode ParagonMode => ParagonMode.Base555;

            public override string TowerSet => "Primary";

            public override bool IsValidCrosspath(int[] tiers) => ModContent.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);

            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade100 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "1-0-0";

            public override string Description => "1-0-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 0;

            public override int Tier => 1;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade200 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "2-0-0";

            public override string Description => "2-0-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 0;

            public override int Tier => 2;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade300 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "3-0-0";

            public override string Description => "3-0-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 0;

            public override int Tier => 3;

            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade400 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "4-0-0";

            public override string Description => "4-0-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 0;

            public override int Tier => 4;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade500 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "5-0-0";

            public override string Description => "5-0-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 0;

            public override int Tier => 5;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade010 : ModUpgrade<TemplateMonkey>
        {
            public override string DisplayName => "0-1-0";

            public override string Description => "0-1-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 1;

            public override int Tier => 1;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade020 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-2-0";

            public override string Description => "0-2-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 1;

            public override int Tier => 2;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade030 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-3-0";

            public override string Description => "0-3-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 1;

            public override int Tier => 3;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade040 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-4-0";

            public override string Description => "0-4-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 1;

            public override int Tier => 4;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade050 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-5-0";

            public override string Description => "0-5-0 Upgrade";

            public override int Cost => 0;

            public override int Path => 1;

            public override int Tier => 5;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade001 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-0-1";

            public override string Description => "0-0-1 Upgrade";

            public override int Cost => 0;

            public override int Path => 2;

            public override int Tier => 1;

            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade002 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-0-2";

            public override string Description => "0-0-2 Upgrade";

            public override int Cost => 0;

            public override int Path => 2;

            public override int Tier => 2;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade003 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-0-3";

            public override string Description => "0-0-3 Upgrade";

            public override int Cost => 0;

            public override int Path => 2;

            public override int Tier => 3;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade004 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-0-4";

            public override string Description => "0-0-4 Upgrade";

            public override int Cost => 0;

            public override int Path => 2;

            public override int Tier => 4;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class Upgrade005 : ModUpgrade<TemplateMonkey>
        {

            public override string DisplayName => "0-0-5";

            public override string Description => "0-0-5 Upgrade";

            public override int Cost => 0;

            public override int Path => 2;

            public override int Tier => 5;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }

            public override string Icon => "";

            public override string Portrait => "";
        }

        public class ParagonDisplay : ModTowerDisplay<TemplateMonkey>
        {
            public override string BaseDisplay => GetDisplay(TowerType.DartMonkey);

            public override bool UseForTower(int[] tiers) => IsParagon(tiers);

            public class UpgradeParagon : ModParagonUpgrade<TemplateMonkey>
            {
                public override int Cost => 0;

                public override string Description => "Paragon Upgrade";

                public override string DisplayName => "Paragon";

                public override void ApplyUpgrade(TowerModel towerModel)
                {
                    
                }

                public override string Icon => "";

                public override string Portrait => "";
            }

            [HarmonyLib.HarmonyPatch(typeof(Assets.Scripts.Unity.UI_New.InGame.InGame), "Update")]
            public class Update_Patch
            {
                [HarmonyLib.HarmonyPostfix]
                public static void Postfix()
                {
                }
            }
        }
    }
}
