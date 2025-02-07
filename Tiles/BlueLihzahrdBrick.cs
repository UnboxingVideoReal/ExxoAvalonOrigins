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
	public class BlueLihzahrdBrick : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(0, 22, 44));
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = mod.ItemType("BlueLihzahrdBrick");
            soundType = SoundID.Tink;
            soundStyle = 1;
            minPick = 400;
            dustType = DustID.t_Granite;
		}
	}
}