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
	class FeroziumArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferozium Arrow");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FeroziumArrow");
			item.damage = 15;
			item.shootSpeed = 4f;
			item.ammo = AmmoID.Arrow;
			item.ranged = true;
			item.consumable = true;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.knockBack = 4f;
			item.shoot = ModContent.ProjectileType<Projectiles.FeroziumArrow>();
			item.value = Item.sellPrice(0, 0, 1, 0);
			item.maxStack = 2000;
			item.height = dims.Height;
		}
	}
}