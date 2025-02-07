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
	[AutoloadEquip(EquipType.Legs)]
	class HellArmoredGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell Armored Greaves");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HellArmoredGreaves");
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.vanity = true;
			item.value = Item.sellPrice(0, 0, 90, 0);
			item.height = dims.Height;
		}
	}
}