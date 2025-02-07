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
	class OsmiumJerkin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Osmium Jerkin");
			Tooltip.SetDefault("15% increased melee damage and speed");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/OsmiumJerkin");
			item.defense = 8;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 20, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.15f;
			player.meleeSpeed += 0.15f;
		}
	}
}