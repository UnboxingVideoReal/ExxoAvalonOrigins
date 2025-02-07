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
	class EarthShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earth Shard");
			Tooltip.SetDefault("'A fragment of earthen creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/EarthShard");
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 6, 0);
			item.height = dims.Height;
		}
	}
}