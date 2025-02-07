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
	class Kunzite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kunzite");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Kunzite");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 999;
			item.createTile = ModContent.TileType<Tiles.PlacedGems>();
			item.placeStyle = 2;
			item.consumable = true;
			item.rare = ItemRarityID.Purple;
			item.width = dims.Width;
			item.useTime = 10;
			item.value = 50000;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}