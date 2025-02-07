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
	class FleshWrappings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flesh Wrappings");
			Tooltip.SetDefault("9% increased minion knockback\n10% increased movement speed");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FleshWrappings");
			item.defense = 9;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 20, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionKB += 0.09f;
			player.moveSpeed += 0.1f;
		}
	}
}