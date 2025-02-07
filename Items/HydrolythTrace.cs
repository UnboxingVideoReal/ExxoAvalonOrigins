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
	class HydrolythTrace : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hydrolyth Trace");
			Tooltip.SetDefault("Calls forth a comet");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HydrolythTrace");
			item.consumable = true;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.value = 0;
			item.maxStack = 999;
			item.useAnimation = 45;
			item.height = dims.Height;
		}
	}
}