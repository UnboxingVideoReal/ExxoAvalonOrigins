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
	class OsmiumGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Osmium Greatsword");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/OsmiumGreatsword");
			item.damage = 28;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.5f;
			item.crit += 5;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.useTime = 20;
			item.knockBack = 5f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 50000;
			item.useAnimation = 20;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
		}
	}
}