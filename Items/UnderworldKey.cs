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
	class UnderworldKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Underworld Key");
			Tooltip.SetDefault("Unlocks an Underworld Chest in the dungeon");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/UnderworldKey");
			item.rare = ItemRarityID.Purple;
			item.width = dims.Width;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}