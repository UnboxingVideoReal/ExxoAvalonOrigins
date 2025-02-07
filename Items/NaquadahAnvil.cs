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
	class NaquadahAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Naquadah Anvil");
			Tooltip.SetDefault("Used to craft items from mythril, orichalcum, naquadah, adamantite, titanium, and troxinium bars");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/NaquadahAnvil");
			item.autoReuse = true;
			item.useTurn = true;
			item.maxStack = 99;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.NaquadahAnvil>();
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 25000;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}