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
	public class ShadowScale : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(Color.LightSteelBlue);
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileFrameImportant[Type] = true;
            drop = ItemID.ShadowScale;
            dustType = DustID.CorruptionThorns;
        }
	}
}