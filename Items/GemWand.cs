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
	class GemWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gem Wand");
			Tooltip.SetDefault("Places ore-form gems");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GemWand");
			item.autoReuse = true;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}