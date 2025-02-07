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
	class CaesiumHeadpiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Caesium Galea");
			Tooltip.SetDefault("8% increased melee damage");
		}
		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CaesiumHeadpiece");
			item.defense = 31;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.height = dims.Height;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<CaesiumPlateMail>() && legs.type == ModContent.ItemType<CaesiumGreaves>();
		}
		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Melee Stealth and increased stats";
			player.meleeDamage += 0.05f;
			//player.thorns = true;
			player.statDefense += 4;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().meleeStealth = true;
		}
		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.08f;
		}
	}
}