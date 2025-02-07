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
	class DurataniumHeadpiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duratanium Headpiece");
			Tooltip.SetDefault("7% increased ranged damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DurataniumHeadpiece");
			item.defense = 7;
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
			player.rangedDamage += 0.07f;
		}
	}
}