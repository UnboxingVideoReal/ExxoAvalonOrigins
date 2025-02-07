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
	class NullEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Null Emblem");
			Tooltip.SetDefault("Craft it into a Wall of Flesh Emblem");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/NullEmblem");
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.height = dims.Height;
		}
	}
}