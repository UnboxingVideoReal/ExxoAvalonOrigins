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
	class ShockwavePotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shockwave Potion");
			Tooltip.SetDefault("Enemies take damage when you land");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ShockwavePotion");
			item.buffType = ModContent.BuffType<Buffs.Shockwave>();
			item.consumable = true;
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.useTime = 15;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 100;
			item.value = 1000;
			item.useAnimation = 15;
			item.height = dims.Height;
			item.buffTime = 25200;
            item.UseSound = SoundID.Item3;
        }
	}
}