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
	class MysticalClaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mystical Claw");
			Tooltip.SetDefault("Part of a beast's body");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MysticalClaw");
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 2, 0);
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}