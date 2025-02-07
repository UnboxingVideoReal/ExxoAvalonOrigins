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
	class Pathogen : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pathogen");
			Tooltip.SetDefault("'Blech'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Pathogen");
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = 4500;
			item.height = dims.Height;
		}
	}
}