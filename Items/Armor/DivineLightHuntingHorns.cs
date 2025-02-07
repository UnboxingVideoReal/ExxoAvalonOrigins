﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    class DivineLightHuntingHorns : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Divine Light Hunting Horns");
			Tooltip.SetDefault("15% increased melee and magic damage"
				+ "\n25% increased ranged damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Armor/DivineLightHuntingHorns");
			item.defense = 10;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 2, 10, 0);
			item.height = dims.Height;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<DivineLightJerkin>() && legs.type == ModContent.ItemType<DivineLightTreads>();
		}

		public override void UpdateArmorSet(Player player)
		{
			ExxoAvalonOriginsModPlayer modPlayer = player.GetModPlayer<ExxoAvalonOriginsModPlayer>();
			player.setBonus = "Reckoning: your reckoning level increases as you attack enemies, up to a maximum of ten"
				+ "\nThe greater your reckoning level, the greater your ranged critical strike chance"
				+ "\nYour reckoning level decreases gradually over time"
				+ "\nReckoning Level: " + modPlayer.reckoningLevel;
			modPlayer.reckoning = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.25f;
			player.meleeDamage += 0.15f;
			player.magicDamage += 0.15f;
		}
	}
}
