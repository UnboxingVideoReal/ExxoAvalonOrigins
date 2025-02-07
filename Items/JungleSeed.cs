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
	class JungleSeed : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle Seed");
			Tooltip.SetDefault("For use with Blowpipes");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/JungleSeed");
			item.damage = 3;
            item.ammo = AmmoID.Dart;
            item.consumable = true;
            item.ranged = true;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.shoot = ModContent.ProjectileType<Projectiles.JungleSeed>();
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}