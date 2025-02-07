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
	class FireShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fire Shard");
			Tooltip.SetDefault("'A fragment of fiery creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FireShard");
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 6, 0);
			item.height = dims.Height;
		}
	}
}