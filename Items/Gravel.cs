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
	class Gravel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gravel");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Gravel");
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 2, 0);
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}