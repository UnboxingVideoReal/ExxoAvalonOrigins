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
	public class MoonplateBlock : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(179, 187, 199));
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
            Main.tileBrick[Type] = true;
			drop = mod.ItemType("MoonplateBlock");
            soundType = SoundID.Tink;
            soundStyle = 1;
        }
	}
}