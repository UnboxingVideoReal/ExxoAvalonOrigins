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
	class TroxiniumForge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Troxinium Forge");
			Tooltip.SetDefault("Used to smelt adamantite, titanium, and troxinium ore");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TroxiniumForge");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 99;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.TroxiniumForge>();
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 55000;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}