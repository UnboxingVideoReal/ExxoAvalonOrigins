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
	class MiloticCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Milotic Crown");
			Tooltip.SetDefault("20% increased minion damage\nIncreases your max number of minions by 1");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MiloticCrown");
			item.defense = 29;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<MiloticSkinplate>() && legs.type == ModContent.ItemType<MiloticJodpurs>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Minions have a chance to freeze your enemies" +
				"\nFrozen enemies or enemies which cannot be frozen take an aadditional 10% damage";
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().minionFreeze = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionDamage += 0.2f;
			player.maxMinions++;
		}
	}
}