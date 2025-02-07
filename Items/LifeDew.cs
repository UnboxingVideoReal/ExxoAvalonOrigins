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
	class LifeDew : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Dew");
			Tooltip.SetDefault("'The essence of living creatures'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/LifeDew");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.maxStack = 999;
			item.value = 400000;
			item.height = dims.Height;
		}
	}
}