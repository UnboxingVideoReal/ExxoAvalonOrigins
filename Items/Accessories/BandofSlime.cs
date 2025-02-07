using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items.Accessories
{
	class BandofSlime : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Band of Slime");
			Tooltip.SetDefault("Reduces damage taken by 10% and negates fall damage\nAll tiles are slippery");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Accessories/BandofSlime");
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.accessory = true;
			item.value = 50000;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().slimeBand = true;
			player.endurance += 0.1f;
			player.noFallDmg = true;
            player.slippy2 = true;
		}
	}
}