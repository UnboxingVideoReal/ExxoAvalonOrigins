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
	class CandyCane2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Candy Cane");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CandyCane2");
			item.potion = true;
			item.consumable = true;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 15;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 70;
			item.value = 100;
			item.useAnimation = 15;
			item.healLife = 60;
			item.height = dims.Height;
            item.UseSound = SoundID.Item2;
        }
	}
}