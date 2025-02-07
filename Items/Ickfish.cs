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
	class Ickfish : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ickfish");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Ickfish");
			item.width = dims.Width;
			item.value = 10;
			item.maxStack = 999;
			item.height = dims.Height;
		}
	}
}