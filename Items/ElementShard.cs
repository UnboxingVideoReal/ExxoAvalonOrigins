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
	class ElementShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Element Shard");
			Tooltip.SetDefault("'A fragment of the elements'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ElementShard");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = 3000;
			item.height = dims.Height;
		}
	}
}