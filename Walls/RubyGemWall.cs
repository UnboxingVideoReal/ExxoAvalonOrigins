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
	public class RubyGemWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = mod.ItemType("RubyGemWall");
            AddMapEntry(new Color(125, 50, 64));
			dustType = DustID.Stone;
		}
	}
}