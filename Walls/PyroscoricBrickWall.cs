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
	public class PyroscoricBrickWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = mod.ItemType("PyroscoricBrickWall");
            AddMapEntry(new Color(154, 40, 0));
			dustType = DustID.InfernoFork;
		}
	}
}