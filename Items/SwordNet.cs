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
	class SwordNet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sword Net");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SwordNet");
			item.damage = 15;
			item.autoReuse = true;
			item.width = dims.Width;
			item.useTurn = true;
			item.knockBack = 1.2f;
			item.useTime = 23;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.useAnimation = 23;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}