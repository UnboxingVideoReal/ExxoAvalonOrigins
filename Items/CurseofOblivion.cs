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
	class CurseofOblivion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Curse of Oblivion");
			Tooltip.SetDefault("'B. Harold'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CurseofOblivion");
			item.autoReuse = true;
			item.consumable = true;
            item.rare = ItemRarityID.Cyan;
            item.createTile = ModContent.TileType<Tiles.Paintings>();
			item.placeStyle = 10;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 10, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}