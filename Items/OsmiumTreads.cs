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
	class OsmiumTreads : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Osmium Treads");
			Tooltip.SetDefault("15% increased magic damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/OsmiumTreads");
			item.defense = 8;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 20, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.15f;
		}
	}
}