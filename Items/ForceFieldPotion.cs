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
	class ForceFieldPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Force Field Potion");
			Tooltip.SetDefault("Enables a projectile-reflecting force field");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ForceFieldPotion");
			item.buffType = ModContent.BuffType<Buffs.ForceField>();
			item.consumable = true;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 15;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 100;
			item.useAnimation = 15;
			item.height = dims.Height;
			item.buffTime = 18000;
            item.UseSound = SoundID.Item3;
        }
	}
}