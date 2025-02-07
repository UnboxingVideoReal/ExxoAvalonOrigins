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
	class Moonphaser : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonphaser");
			Tooltip.SetDefault("Changes the phases of the Moon\nHas a chance to trigger a Blood Moon if night");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Moonphaser");
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 30;
			item.shoot = ModContent.ProjectileType<Projectiles.Moonphaser>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 2, 70, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}