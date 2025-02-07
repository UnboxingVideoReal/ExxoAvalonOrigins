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
	class UnderworldKeyMold : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Underworld Key Mold");
			Tooltip.SetDefault("Used for crafting an Underworld Key");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/UnderworldKeyMold");
			item.rare = ItemRarityID.Purple;
			item.width = dims.Width;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}