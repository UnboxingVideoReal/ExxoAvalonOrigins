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
	class RubybeadHerb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rubybead Herb");
			Tooltip.SetDefault("A mystical object containing an unknown force");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/RubybeadHerb");
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 2, 0);
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}