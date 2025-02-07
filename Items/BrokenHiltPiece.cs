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
	class BrokenHiltPiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Hilt Piece");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BrokenHiltPiece");
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.value = 50;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}