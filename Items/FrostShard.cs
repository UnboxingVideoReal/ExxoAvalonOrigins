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
	class FrostShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Shard");
			Tooltip.SetDefault("'A fragment of icy creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FrostShard");
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 6, 0);
			item.height = dims.Height;
		}
	}
}