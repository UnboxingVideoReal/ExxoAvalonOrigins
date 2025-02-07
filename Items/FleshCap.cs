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
	class FleshCap : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flesh Cap");
			Tooltip.SetDefault("10% increased minion damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FleshCap");
			item.defense = 7;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<FleshWrappings>() && legs.type == ModContent.ItemType<FleshPants>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Hungry minions can be summoned up to 10";
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().fleshLaser = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionDamage += 0.1f;
		}
	}
}