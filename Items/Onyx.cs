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
	class Onyx : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Onyx");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Onyx");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 999;
            item.createTile = ModContent.TileType<Tiles.PlacedGems>();
			item.placeStyle = 1;
			item.consumable = true;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.useTime = 10;
			item.value = 30000;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}