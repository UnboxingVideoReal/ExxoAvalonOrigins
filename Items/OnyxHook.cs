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
	class OnyxHook : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Onyx Hook");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/OnyxHook");
			item.noUseGraphic = true;
			item.damage = 70;
			item.useTurn = true;
			item.shootSpeed = 16f;
			item.rare = ItemRarityID.Lime;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 20;
			item.knockBack = 25f;
			item.shoot = ModContent.ProjectileType<Projectiles.OnyxHook>();
			item.value = Item.sellPrice(0, 9, 0, 0);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 20;
			item.height = dims.Height;
		}
	}
}