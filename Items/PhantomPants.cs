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
	class PhantomPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phantom Pants");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/PhantomPants");
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.height = dims.Height;
		}
	}
}