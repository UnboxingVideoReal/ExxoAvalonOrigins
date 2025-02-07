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
	[AutoloadEquip(EquipType.Shield)]
	class AegisofAges : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aegis of Ages");
			Tooltip.SetDefault("+20 defense, +5 life regeneration, +20% damage\nEffects are only active when below 33% life");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/AegisofAges");
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 25, 0, 0);
			item.accessory = true;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (player.statLife <= player.statLifeMax2 * 0.33)
			{
				player.statDefense += 20;
				player.lifeRegen += 5;
				player.magicDamage += 0.2f;
				player.meleeDamage += 0.2f;
				player.minionDamage += 0.2f;
				player.rangedDamage += 0.2f;
			}
		}
	}
}