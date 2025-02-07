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
	class VisionPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vision Potion");
			Tooltip.SetDefault("Open caves light up");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/VisionPotion");
			item.buffType = ModContent.BuffType<Buffs.Vision>();
			item.consumable = true;
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.useTime = 15;
			item.value = 2000;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 30;
			item.useAnimation = 15;
			item.height = dims.Height;
			item.buffTime = 5400;
            item.UseSound = SoundID.Item3;
        }
	}
}