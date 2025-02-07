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
	class LightninginaBottle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightning in a Bottle");
			Tooltip.SetDefault("Lightning strikes you when damaged");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/LightninginaBottle");
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 1, 44, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().LightningInABottle = true;
		}
	}
}