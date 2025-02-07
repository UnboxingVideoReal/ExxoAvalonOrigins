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
	public class ImperviousBrickWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
            AddMapEntry(new Color(51, 44, 48));
            drop = mod.ItemType("ImperviousBrickWall");
            dustType = DustID.Wraith;
		}
	}
}