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
	class EarthenInsignia : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earthen Insignia");
			Tooltip.SetDefault("Earth related items receive a stat boost");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/EarthenInsignia");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 3, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().earthInsig = true;
		}
	}
}