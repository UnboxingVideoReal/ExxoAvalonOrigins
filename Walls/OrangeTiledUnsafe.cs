using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Walls
{
	public class OrangeTiledUnsafe : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallDungeon[Type] = true;
			drop = mod.ItemType("OrangeTiledUnsafe");
			AddMapEntry(new Color(107, 33, 0));
            dustType = DustID.Coralstone;
		}
	}
}