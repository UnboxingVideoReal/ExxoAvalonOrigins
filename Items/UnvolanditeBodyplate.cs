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
	class UnvolanditeBodyplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unvolandite Bodyplate");
			Tooltip.SetDefault("Enemies are a lot more likely to target you\nMinion knockback is increased by 10%");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/UnvolanditeBodyplate");
			item.defense = 33;
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.aggro += 1500;
			player.minionKB += 0.1f;
		}
	}
}