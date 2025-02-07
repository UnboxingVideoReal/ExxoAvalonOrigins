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
	public class EctoplasmWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = mod.ItemType("EctoplasmWall");
            AddMapEntry(new Color(0, 131, 181));
            dustType = DustID.Ultrabright;
		}
	}
}