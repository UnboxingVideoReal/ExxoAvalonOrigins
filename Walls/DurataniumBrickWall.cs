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
	public class DurataniumBrickWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = mod.ItemType("DurataniumBrickWall");
            AddMapEntry(new Color(91, 0, 54));
			dustType = dustType = ModContent.DustType<Dusts.DurataniumDust>();
		}
	}
}