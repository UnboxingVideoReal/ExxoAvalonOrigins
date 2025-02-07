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
	class SunCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sun Charm");
			Tooltip.SetDefault("Summons a Solar Eclipse");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SunCharm");
			item.consumable = true;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.useTime = 40;
			item.shoot = ModContent.ProjectileType<Projectiles.SunCharm>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 999;
			item.useAnimation = 40;
			item.height = dims.Height;
		}

        public override bool CanUseItem(Player player)
        {
            if (!Main.dayTime) return false;
            return true;
        }
    }
}