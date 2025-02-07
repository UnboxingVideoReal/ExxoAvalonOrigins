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
	class DesertFeather : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Feather");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DesertFeather");
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 1, 0);
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}