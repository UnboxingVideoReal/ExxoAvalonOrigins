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
	public class DarkMatterSlimeBlock : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = mod.ItemType("DarkSlimeBlockWall");
            AddMapEntry(new Color(51, 0, 96));
            dustType = DustID.UnholyWater;
		}
	}
}