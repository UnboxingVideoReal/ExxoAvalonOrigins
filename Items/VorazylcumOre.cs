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
	class VorazylcumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vorazylcum Ore");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/VorazylcumOre");
			item.autoReuse = true;
			item.createTile = ModContent.TileType<Tiles.VorazylcumOre>();
			item.consumable = true;
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.useTime = 10;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 0, 50, 0);
			item.maxStack = 999;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}