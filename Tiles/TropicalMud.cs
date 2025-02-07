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
	public class TropicalMud : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(95, 38, 12));
			Main.tileSolid[Type] = true;
			Main.tileMerge[TileID.Dirt][Type] = true;
            Main.tileMerge[Type][TileID.Dirt] = true;
            Main.tileBrick[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = mod.ItemType("TropicalMudBlock");
			dustType = ModContent.DustType<Dusts.TropicalMudDust>();
        }
	}
}