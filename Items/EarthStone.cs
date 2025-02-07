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
	class EarthStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earth Stone");
			Tooltip.SetDefault("'The essence of the golem'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/EarthStone");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.height = dims.Height;
		}
	}
}