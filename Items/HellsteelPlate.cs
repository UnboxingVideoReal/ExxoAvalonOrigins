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
	class HellsteelPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellsteel Plate");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HellsteelPlate");
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 2);
			item.height = dims.Height;
		}
	}
}