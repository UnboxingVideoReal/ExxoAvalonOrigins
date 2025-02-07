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
	class Icicle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icicle");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Icicle");
			item.damage = 11;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.shootSpeed = 9f;
			item.ranged = true;
			item.consumable = true;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 15;
			item.knockBack = 3f;
			item.shoot = ModContent.ProjectileType<Projectiles.Icicle>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 0;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}