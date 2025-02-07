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
	class AlienDevice : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Alien Device");
			Tooltip.SetDefault("Used for crafting the Eye of Oblivion");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/AlienDevice");
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = 0;
			item.height = dims.Height;
		}
	}
}