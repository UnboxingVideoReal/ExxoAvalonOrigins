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
	class NaturesEndowment : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nature's Endowment");
			Tooltip.SetDefault("25% decreased mana usage\n+20 mana");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/NaturesEndowment");
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 2, 36, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.manaCost -= 0.25f;
			player.statManaMax2 += 20;
		}
	}
}