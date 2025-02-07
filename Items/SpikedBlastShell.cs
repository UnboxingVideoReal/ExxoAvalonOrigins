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
	class SpikedBlastShell : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spiked Blast Shell");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SpikedBlastShell");
			item.rare = -12;
			item.width = dims.Width;
			item.value = 5000;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}