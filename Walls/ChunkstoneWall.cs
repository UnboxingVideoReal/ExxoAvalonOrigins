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
	public class ChunkstoneWall : ModWall
	{
		public override void SetDefaults()
		{
			WallID.Sets.Conversion.Stone[Type] = true;
            AddMapEntry(new Color(34, 44, 25));
            dustType = ModContent.DustType<Dusts.ContagionDust>();
		}
	}
}