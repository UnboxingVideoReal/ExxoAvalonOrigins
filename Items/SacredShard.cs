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
	class SacredShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sacred Shard");
			Tooltip.SetDefault("'A fragment of hallow creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SacredShard");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.Shards>();
			item.placeStyle = 8;
			item.rare = ItemRarityID.LightPurple;
			item.width = dims.Width;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 0, 12, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}