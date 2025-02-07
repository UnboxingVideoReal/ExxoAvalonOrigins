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
	class CrystalEdge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Edge");
			Tooltip.SetDefault("Increases damage by 25%");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CrystalEdge");
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 4, 0, 0);
			item.height = dims.Height;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magicDamage += 0.25f;
            player.meleeDamage += 0.25f;
            player.minionDamage += 0.25f;
            player.thrownDamage += 0.25f;
            player.rangedDamage += 0.25f;
        }
    }
}