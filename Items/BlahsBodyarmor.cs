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
	[AutoloadEquip(EquipType.Body)]
	class BlahsBodyarmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blah's Bodyarmor");
			Tooltip.SetDefault("30% decreased mana usage and increases your max number of minions by 6\nIncreases maximum mana by 500");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BlahsBodyarmor");
			item.defense = 50;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.value = Item.sellPrice(1, 0, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.aggro += 1000;
			player.manaCost -= 0.3f;
			player.statManaMax2 += 500;
			player.maxMinions += 12;
		}
	}
}