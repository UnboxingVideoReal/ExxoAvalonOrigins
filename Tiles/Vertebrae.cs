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
	public class Vertebrae : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(255, 127, 127));
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = ItemID.Vertebrae;
            soundType = SoundID.NPCHit;
            soundStyle = 2;
            dustType = DustID.HeartCrystal;
        }
	}
}