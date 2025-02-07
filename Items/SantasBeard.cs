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
	[AutoloadEquip(EquipType.Face)]
	class SantasBeard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Santa's Beard");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SantasBeard");
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.maxStack = 1;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.accessory = true;
			item.vanity = true;
			item.height = dims.Height;
		}
	}
}