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
	class CaesiumGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Caesium Greaves");
			Tooltip.SetDefault("15% increased melee and movement speed");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CaesiumGreaves");
			item.defense = 21;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 8, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.15f;
			player.moveSpeed += 0.15f;
		}
	}
}