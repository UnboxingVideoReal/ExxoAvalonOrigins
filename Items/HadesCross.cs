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
	class HadesCross : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hades' Cross");
			Tooltip.SetDefault("Provides the ability to breathe in, and free movement in lava\nNegates damage from lava");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HadesCross");
			item.defense = 3;
			item.rare = ItemRarityID.LightPurple;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 9, 72, 0);
			item.accessory = true;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			var flag = Collision.LavaCollision(player.position, player.width, player.height);
			if (flag)
			{
				player.GetModPlayer<ExxoAvalonOriginsModPlayer>().mermanLava = true;
                player.merman = true;
				player.accFlipper = true;
				player.ignoreWater = true;
				player.lavaImmune = true;
			}
			player.lavaImmune = true;
			player.fireWalk = true;
			player.waterWalk = true;
		}
	}
}