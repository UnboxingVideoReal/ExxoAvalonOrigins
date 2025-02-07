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
	class ContagionKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Contagion Key");
			Tooltip.SetDefault("Opens a Contagion Chest in the Dungeon");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ContagionKey");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.scale = 1f;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}