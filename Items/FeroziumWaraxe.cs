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
	class FeroziumWaraxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferozium Waraxe");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FeroziumWaraxe");
			item.damage = 30;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.5f;
			item.axe = 24;
			item.crit += 2;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.useTime = 20;
			item.knockBack = 8f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 350000;
			item.useAnimation = 20;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}