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
	class Oblivionet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oblivionet");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Oblivionet");
			item.damage = 70;
			item.autoReuse = true;
			item.useTurn = true;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.knockBack = 6.2f;
			item.useTime = 21;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.useAnimation = 21;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}