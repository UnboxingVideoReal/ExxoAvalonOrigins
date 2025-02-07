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
	class WaterShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Water Shard");
			Tooltip.SetDefault("'A fragment of water creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/WaterShard");
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 6, 0);
			item.height = dims.Height;
		}
	}
}