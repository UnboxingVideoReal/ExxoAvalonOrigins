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
	class OsmiumHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Osmium Helmet");
			Tooltip.SetDefault("15% increased ranged damage\nIncreases maximum mana by 40");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/OsmiumHelmet");
			item.defense = 8;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 20, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<OsmiumJerkin>() && legs.type == ModContent.ItemType<OsmiumTreads>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+3 defense and 20% increased melee speed";
			player.meleeSpeed += 0.2f;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 40;
			player.rangedDamage += 0.15f;
		}
	}
}