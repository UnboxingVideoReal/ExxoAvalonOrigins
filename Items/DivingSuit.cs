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
	class DivingSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diving Suit");
			Tooltip.SetDefault("Greatly extends underwater breathing\n10% increased damage while in water");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DivingSuit");
			item.defense = 4;
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.breathMax *= 3; //TODO: fix.
			if (player.wet)
			{
				player.meleeDamage += 0.1f;
				player.magicDamage += 0.1f;
				player.rangedDamage += 0.1f;
			}
		}
	}
}