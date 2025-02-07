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
	class EyeoftheGods : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye of the Gods");
			Tooltip.SetDefault("Shows the location and stats of enemies");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/EyeoftheGods");
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 3, 0, 0);
			item.height = dims.Height;
		}
	}
}