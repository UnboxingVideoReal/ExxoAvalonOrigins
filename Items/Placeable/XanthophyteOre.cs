using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items.Placeable
{
	class XanthophyteOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Xanthophyte Ore");
			Tooltip.SetDefault("'It glows warmly in the sun'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Placeable/XanthophyteOre");
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.Ores.XanthophyteOre>();
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.useTime = 10;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 15, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}