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
	class BloodberrySeeds : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloodberry Seeds");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BloodberrySeeds");
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.Herbs.Bloodberry>();
			item.placeStyle = 0;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 999;
			item.value = 90;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}