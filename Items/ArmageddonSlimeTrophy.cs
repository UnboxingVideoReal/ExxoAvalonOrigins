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
	class ArmageddonSlimeTrophy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Armageddon Slime Trophy");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ArmageddonSlimeTrophy");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 99;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.BossTrophy>();
			item.placeStyle = 1;
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}