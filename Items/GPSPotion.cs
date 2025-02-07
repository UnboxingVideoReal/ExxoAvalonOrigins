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
	class GPSPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("GPS Potion");
			Tooltip.SetDefault("GPS Effect");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GPSPotion");
			item.buffType = ModContent.BuffType<Buffs.GPS>();
			item.consumable = true;
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.useTime = 15;
			item.value = 2000;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 100;
			item.useAnimation = 15;
			item.height = dims.Height;
			item.buffTime = 18000;
            item.UseSound = SoundID.Item3;
        }
	}
}