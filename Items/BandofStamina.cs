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
	class BandofStamina : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Band of Stamina");
			Tooltip.SetDefault("Increases maximum stamina by 60");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BandofStamina");
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.accessory = true;
			item.value = 50000;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().statStamMax2 += 60;
		}
	}
}