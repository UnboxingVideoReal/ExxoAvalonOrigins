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
	class HellstoneSeed : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellstone Dart");
			Tooltip.SetDefault("For use with Blowpipes");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HellstoneSeed");
			item.damage = 9;
            item.consumable = true;
            item.ammo = AmmoID.Dart;
            item.ranged = true;
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.shoot = ModContent.ProjectileType<Projectiles.HellstoneSeed>();
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}