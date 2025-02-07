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
	class HallowedAltar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Altar");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HallowedAltar");
            item.useTurn = true;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.HallowedAltar>();
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.useTime = 20;
			item.maxStack = 99;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 20;
			item.height = dims.Height;
		}
	}
}