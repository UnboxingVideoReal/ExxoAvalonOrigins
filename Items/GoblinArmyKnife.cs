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
	class GoblinArmyKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goblin Army Knife");
			Tooltip.SetDefault("Immune time after being damaged increased, provides life/mana regen, +7% dmg and the holder can quintuple jump\nTells time, provides light, shows position, +4 block range, can craft certain items by hand, +2% crit, Shows ores/mobs");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GoblinArmyKnife");
			item.lifeRegen = 2;
			item.defense = 4;
			item.rare = ItemRarityID.LightPurple;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 15, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.tileSpeed += 1f;
			player.wallSpeed += 1f;
			Player.tileRangeX += 4;
			Player.tileRangeY += 4;
			player.accWatch = 3;
			player.accCompass = 1;
			player.accDepthMeter = 1;
			Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 2f, 2f, 2f);
			if (player.GetModPlayer<ExxoAvalonOriginsModPlayer>().quintJump)
			{
				player.doubleJumpCloud = player.doubleJumpSandstorm = player.doubleJumpBlizzard = true;
			}
			player.jumpBoost = player.GetModPlayer<ExxoAvalonOriginsModPlayer>().magnet = player.GetModPlayer<ExxoAvalonOriginsModPlayer>().longInvince2 = player.longInvince = player.detectCreature = player.findTreasure = true;
			player.manaRegenDelayBonus++;
			player.manaRegenBonus += 25;
			player.meleeDamage += 0.07f;
			player.rangedDamage += 0.07f;
			player.magicDamage += 0.07f;
			player.minionDamage += 0.07f;
			player.magicCrit += 2;
			player.meleeCrit += 2;
			player.rangedCrit += 2;
		}
	}
}