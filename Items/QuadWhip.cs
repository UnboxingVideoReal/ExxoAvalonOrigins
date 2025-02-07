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
	class QuadWhip : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Quad Whip");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/QuadWhip");
			item.noUseGraphic = true;
			item.useTurn = true;
			item.shootSpeed = 16f;
			item.rare = ItemRarityID.Yellow;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 20;
			item.knockBack = 7f;
			item.shoot = ModContent.ProjectileType<Projectiles.QuadHook>();
			item.value = Item.sellPrice(0, 12, 0, 0);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 20;
			item.height = dims.Height;
		}
	}
}