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
	class Zircon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zircon");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Zircon");
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.value = 4400;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}