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
	class IckyAltar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icky Altar");
			Tooltip.SetDefault("The spirit of Cthulhu guards this altar");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/IckyAltar");
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.IckyAltar>();
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.useTime = 20;
			item.maxStack = 99;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 20;
			item.height = dims.Height;
		}
	}
}