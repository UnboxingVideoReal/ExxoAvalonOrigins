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
	class MushroomBomb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mushroom Bomb");
			Tooltip.SetDefault("Converts tiles to Mushrooms in a large radius\nNot the kind you think.");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MushroomBomb");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 999;
			item.mech = true;
			item.createTile = ModContent.TileType<Tiles.BiomeBombs>();
			item.placeStyle = 5;
			item.consumable = true;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}