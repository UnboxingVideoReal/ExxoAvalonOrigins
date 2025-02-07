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
	class MiloticSkinplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Milotic Skinplate");
			Tooltip.SetDefault("30% increased minion knockback\nIncreases your max number of minions by 2");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MiloticSkinplate");
			item.defense = 30;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionKB += 0.3f;
			player.maxMinions += 2;
		}
	}
}