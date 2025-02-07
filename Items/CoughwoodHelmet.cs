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
	[AutoloadEquip(EquipType.Head)]
	class CoughwoodHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Coughwood Helmet");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CoughwoodHelmet");
			item.defense = 2;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 2, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<CoughwoodBreastplate>() && legs.type == ModContent.ItemType<CoughwoodGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+1 defense";
			player.statDefense++;
		}
	}
}