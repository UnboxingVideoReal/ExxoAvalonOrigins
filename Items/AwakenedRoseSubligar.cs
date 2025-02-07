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
	[AutoloadEquip(EquipType.Legs)]
	class AwakenedRoseSubligar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Awakened Rose Subligar");
			Tooltip.SetDefault("10% increased movement speed" 
				+ "\n10% decreased mana cost");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/AwakenedRoseSubligar");
			item.defense = 20;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.1f;
			player.manaCost -= 0.1f;
		}
	}
}