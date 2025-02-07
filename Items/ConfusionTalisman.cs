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
	class ConfusionTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Confusion Talisman");
			Tooltip.SetDefault("12% chance for your attacks to confuse your enemies");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ConfusionTalisman");
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 3, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().confusionTal = true; //unimplemented
		}
	}
}