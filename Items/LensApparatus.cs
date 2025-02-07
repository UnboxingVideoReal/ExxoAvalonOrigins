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
	class LensApparatus : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lens Apparatus");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/LensApparatus");
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 60, 0);
			item.height = dims.Height;
		}
	}
}