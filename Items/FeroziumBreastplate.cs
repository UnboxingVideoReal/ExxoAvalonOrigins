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
	class FeroziumBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferozium Breastplate");
			Tooltip.SetDefault("17% increased melee and ranged critical strike chance");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FeroziumBreastplate");
			item.defense = 23;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.value = 300000;
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeCrit += 17;
			player.rangedCrit += 17;
		}
	}
}