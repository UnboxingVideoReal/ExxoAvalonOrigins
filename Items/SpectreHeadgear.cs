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
	class SpectreHeadgear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectre Headgear");
			Tooltip.SetDefault("10% decreased mana usage\n10% increased magic damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SpectreHeadgear");
			item.defense = 11;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.value = 375000;
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.1f;
			player.manaCost -= 0.1f;
		}
	}
}