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
	class BrokenVigilanteTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Vigilante Tome");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BrokenVigilanteTome");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.height = dims.Height;
		}
	}
}