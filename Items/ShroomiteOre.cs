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
	class ShroomiteOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shroomite Ore");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ShroomiteOre");
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.ShroomiteOre>();
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 40, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}