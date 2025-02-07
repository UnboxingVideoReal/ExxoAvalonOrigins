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
	class DesertKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Key");
			Tooltip.SetDefault("Unlocks a Desert Chest in the dungeon");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DesertKey");
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}