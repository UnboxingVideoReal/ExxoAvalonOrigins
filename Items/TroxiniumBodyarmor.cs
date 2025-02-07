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
	[AutoloadEquip(EquipType.Body)]
	class TroxiniumBodyarmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Troxinium Bodyarmor");
			Tooltip.SetDefault("8% increased damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TroxiniumBodyarmor");
			item.defense = 15;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 2, 60, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.08f;
			player.rangedDamage += 0.08f;
			player.minionDamage += 0.08f;
			player.meleeDamage += 0.08f;
		}
	}
}