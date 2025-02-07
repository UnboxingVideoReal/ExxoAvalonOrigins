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
	class UndeadTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Undead Talisman");
			Tooltip.SetDefault("Provides 20 defense against undead monsters");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Accessories/UndeadTalisman");
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 50, 0);
			item.accessory = true;
			item.height = dims.Height;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<ExxoAvalonOriginsModPlayer>().undeadTalisman = true;
        }
    }
}