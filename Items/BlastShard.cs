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
	class BlastShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blast Shard");
			Tooltip.SetDefault("'A fragment of fiery creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BlastShard");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.Shards>();
			item.placeStyle = 0;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 0, 12, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}