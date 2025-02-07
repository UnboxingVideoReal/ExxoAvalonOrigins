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
	public class RottenChunk : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(83, 65, 67));
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
            drop = ItemID.RottenChunk;
            dustType = DustID.Bone;
        }
	}
}