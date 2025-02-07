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
	class ChaosEye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chaos Eye");
			Tooltip.SetDefault("Critical strike chance increases as your health drops\n8% increased critical strike chance");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ChaosEye");
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.value = 3450000;
			item.accessory = true;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().chaosCharm = true;
			player.meleeCrit += 8;
			player.rangedCrit += 8;
			player.magicCrit += 8;
            player.thrownCrit += 8;
		}
	}
}