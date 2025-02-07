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
	class ViruthornHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Viruthorn Helmet");
			Tooltip.SetDefault("3% increased damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ViruthornHelmet");
			item.defense = 6;
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 0, 54, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ViruthornScalemail>() && legs.type == ModContent.ItemType<ViruthornGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "10% increased critical strike chance";
			player.meleeCrit += 10;
			player.rangedCrit += 10;
			player.magicCrit += 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.03f;
			player.meleeDamage += 0.03f;
			player.minionDamage += 0.03f;
			player.rangedDamage += 0.03f;
		}
	}
}