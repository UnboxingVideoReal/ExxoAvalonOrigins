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
	public class Coughwood : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(116, 138, 106));
			Main.tileSolid[Type] = true;
			drop = mod.ItemType("Coughwood");
            dustType = ModContent.DustType<Dusts.CoughwoodDust>();
        }
	}
}