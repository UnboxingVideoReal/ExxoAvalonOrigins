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
	class StrengthPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strength Potion");
			Tooltip.SetDefault("Increases all stats");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/StrengthPotion");
			item.buffType = ModContent.BuffType<Buffs.Strong>();
			item.consumable = true;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.useTime = 15;
			item.value = 2000;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 100;
			item.useAnimation = 15;
			item.height = dims.Height;
			item.buffTime = 32400;
            item.UseSound = SoundID.Item3;
        }
	}
}