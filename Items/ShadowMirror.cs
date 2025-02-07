using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items
{
	class ShadowMirror : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Mirror");
			Tooltip.SetDefault("Gaze in the mirror to return home");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ShadowMirror");
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.useTime = 90;
			item.useTurn = true;
			item.value = 500000;
			item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item6;
			item.useAnimation = 90;
			item.height = dims.Height;
		}
        public override void UpdateInventory(Player player)
        {
            player.accThirdEye = player.accFishFinder = player.accWeatherRadio = player.accCalendar = player.accCritterGuide = player.accDreamCatcher =
                player.accJarOfSouls = player.accStopwatch = player.accOreFinder = true;
            player.accWatch = 3;
            player.accDepthMeter = 1;
            player.accCompass = 1;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            var assignedKeys = ExxoAvalonOrigins.modeChangeHotkey.GetAssignedKeys();

            var assignedKeyInfo = new TooltipLine(mod, "Controls:PromptKey", "Press " + (assignedKeys.Count > 0 ? string.Join(", ", assignedKeys) : "[c/565656:<Unbound>]") + " to change teleportation modes");
            tooltips.Add(assignedKeyInfo);

            if (!(assignedKeys.Count > 0))
            {
                var unboundKeyInfo = new TooltipLine(mod, "Controls:PromptKeyInfo", "[c/900C3F:Please bind hotkey in the settings to change teleportation modes!]");
                tooltips.Add(unboundKeyInfo);
            }
        }
        public override bool UseItem(Player player)
        {
            if (player.whoAmI == Main.myPlayer)
            {
                int d = 15;
                switch (player.GetModPlayer<ExxoAvalonOriginsModPlayer>().shadowWP)
                {
                    case 0:
                        d = DustID.MagicMirror;
                        break;
                    case 1:
                        d = ModContent.DustType<Dusts.DungeonTeleportDust>();
                        break;
                    case 2:
                        d = ModContent.DustType<Dusts.JungleTeleportDust>();
                        break;
                    case 3:
                    case 4:
                        d = ModContent.DustType<Dusts.OceanTeleportDust>();
                        break;
                    case 5:
                        d = ModContent.DustType<Dusts.DemonConchDust>();
                        break;
                    default:
                        d = DustID.MagicMirror;
                        break;
                }
                for (int num365 = 0; num365 < 70; num365++)
                {
                    int dust = Dust.NewDust(player.position, player.width, player.height, d, player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 150, default(Color), 1.5f);
                    Main.dust[dust].noGravity = true;
                }
                player.grappling[0] = -1;
                player.grapCount = 0;
                for (int num366 = 0; num366 < 1000; num366++)
                {
                    if (Main.projectile[num366].active && Main.projectile[num366].owner == player.whoAmI && Main.projectile[num366].aiStyle == 7)
                    {
                        Main.projectile[num366].Kill();
                    }
                }
                player.GetModPlayer<ExxoAvalonOriginsModPlayer>().shadowTele = true;
                player.GetModPlayer<ExxoAvalonOriginsModPlayer>().ShadowTP(player.GetModPlayer<ExxoAvalonOriginsModPlayer>().shadowWP, player.whoAmI);
                player.GetModPlayer<ExxoAvalonOriginsModPlayer>().shadowTele = false;
                for (int num367 = 0; num367 < 70; num367++)
                {
                    int dust = Dust.NewDust(player.position, player.width, player.height, d, 0f, 0f, 150, default(Color), 1.5f);
                    Main.dust[dust].noGravity = true;
                }
            }
            return true;
        }
    }
}