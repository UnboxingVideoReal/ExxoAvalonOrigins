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
	class GreekExtinguisher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Greek Extinguisher");
			Tooltip.SetDefault("Immunity to Cursed Inferno");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GreekExtinguisher");
			item.rare = ItemRarityID.LightPurple;
			item.width = dims.Width;
			item.accessory = true;
			item.value = 100000;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.buffImmune[BuffID.CursedInferno] = true;
		}
	}
}