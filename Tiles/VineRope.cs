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
	public class VineRope : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(Color.Lime);
			Main.tileLavaDeath[Type] = true;
			Main.tileRope[Type] = true;
            drop = ItemID.Vine;
            dustType = DustID.Grass;
        }
	}
}