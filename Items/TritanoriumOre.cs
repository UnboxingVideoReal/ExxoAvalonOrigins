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
	class TritanoriumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tritanorium Ore");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TritanoriumOre");
			item.autoReuse = true;
			item.createTile = ModContent.TileType<Tiles.TritanoriumOre>();
			item.consumable = true;
			item.rare = ItemRarityID.Purple;
			item.width = dims.Width;
			item.useTime = 10;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.maxStack = 999;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}