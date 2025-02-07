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
	class DurataniumHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duratanium Helmet");
			Tooltip.SetDefault("5% increased melee damage and speed\nEnemies are more likely to target you");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DurataniumHelmet");
			item.defense = 13;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 40, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<DurataniumChainmail>() && legs.type == ModContent.ItemType<DurataniumGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Defense is increased by 12 while you are affected by a debuff";
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().defDebuff = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.05f;
			player.meleeSpeed += 0.05f;
			player.aggro += 100;
		}
	}
}