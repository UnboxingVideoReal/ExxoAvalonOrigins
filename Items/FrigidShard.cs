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
	class FrigidShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frigid Shard");
			Tooltip.SetDefault("'A fragment of icy creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FrigidShard");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.Shards>();
			item.placeStyle = 1;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 0, 12, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}