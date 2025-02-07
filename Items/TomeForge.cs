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
	class TomeForge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome Forge");
			Tooltip.SetDefault("Used to craft Mystical Tomes");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TomeForge");
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.TomeForge>();
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}