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
	class NuclearExtinguisher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nuclear Extinguisher");
			Tooltip.SetDefault("Immunity to Blackout and Cursed Inferno");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/NuclearExtinguisher");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.accessory = true;
			item.value = 200000;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.buffImmune[BuffID.Blackout] = true;
				player.buffImmune[BuffID.CursedInferno] = true;
		}
	}
}