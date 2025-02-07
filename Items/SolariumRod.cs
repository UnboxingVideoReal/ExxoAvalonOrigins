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
	class SolariumRod : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solarium Rod");
			Tooltip.SetDefault("Use at a Solarium Shrine");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SolariumRod");
			item.consumable = true;
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.maxStack = 100;
			item.height = dims.Height;
		}
	}
}