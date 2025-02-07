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
	public class RhodiumBrick : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(Color.Pink);
			Main.tileSolid[Type] = true;
			Main.tileBrick[Type] = true;
			drop = mod.ItemType("RhodiumBrick");
            soundType = SoundID.Tink;
            soundStyle = 1;
            dustType = DustID.t_LivingWood;
        }
	}
}