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
	class RedVelvetCandyCaneWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Velvet Candy Cane Wall");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/RedVelvetCandyCaneWall");
			item.autoReuse = true;
			item.consumable = true;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 7;
			item.createWall = ModContent.WallType<Walls.RedVelvetCandyCaneWall>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 999;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}