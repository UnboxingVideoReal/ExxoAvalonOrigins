using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ObjectData;

namespace ExxoAvalonOrigins.Tiles
{
	public class BlightsoulBlock : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(Color.DarkGray);
			Main.tileSolid[Type] = true;
			drop = ModContent.ItemType<Items.SoulofBlight>();
            dustType = ModContent.DustType<Dusts.Dust234>();
		}
	}
}