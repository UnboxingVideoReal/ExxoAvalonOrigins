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
	class SolarFragment : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Fragment");
			Tooltip.SetDefault("'Hot!'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SolarFragment");
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.value = 10;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}