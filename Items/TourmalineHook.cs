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
	class TourmalineHook : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tourmaline Hook");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TourmalineHook");
			item.noUseGraphic = true;
			item.useTurn = true;
			item.shootSpeed = 16f;
			item.rare = ItemRarityID.Blue;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 20;
			item.shoot = ModContent.ProjectileType<Projectiles.TourmalineHook>();
			item.value = Item.sellPrice(0, 0, 54, 0);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 20;
			item.height = dims.Height;
		}
	}
}