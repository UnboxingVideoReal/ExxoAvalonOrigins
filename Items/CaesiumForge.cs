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
	class CaesiumForge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Caesium Forge");
			Tooltip.SetDefault("Used to smelt high-end ore");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CaesiumForge");
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.CaesiumForge>();
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 99;
			item.value = 50000;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}