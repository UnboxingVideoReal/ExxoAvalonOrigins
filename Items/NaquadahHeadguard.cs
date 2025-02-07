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
	class NaquadahHeadguard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Naquadah Headguard");
			Tooltip.SetDefault("7% increased ranged damage\n10% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/NaquadahHeadguard");
			item.defense = 10;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 2, 40, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<NaquadahBreastplate>() && legs.type == ModContent.ItemType<NaquadahShinguards>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Nearby enemies receive damage when you are damaged";
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().auraThorns = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.07f;
			player.ammoCost80 = true;
		}
	}
}