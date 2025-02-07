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
	class PhantomMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phantom Mask");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/PhantomMask");
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 10, 0);
			item.height = dims.Height;
		}
	}
}