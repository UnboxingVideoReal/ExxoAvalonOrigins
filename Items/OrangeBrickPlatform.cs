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
	class OrangeBrickPlatform : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orange Platform");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/OrangeBrickPlatform");
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.OrangeBrickPlatform>();
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 999;
			item.value = 300;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}