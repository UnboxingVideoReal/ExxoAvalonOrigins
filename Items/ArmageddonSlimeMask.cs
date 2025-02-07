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
	class ArmageddonSlimeMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Armageddon Slime Mask");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ArmageddonSlimeMask");
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.vanity = true;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.height = dims.Height;
		}
	}
}