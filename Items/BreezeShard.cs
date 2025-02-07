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
	class BreezeShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Breeze Shard");
			Tooltip.SetDefault("'A fragment of flying creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BreezeShard");
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 6, 0);
			item.height = dims.Height;
		}
	}
}