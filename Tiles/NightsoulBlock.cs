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
	public class NightsoulBlock : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(Color.LightBlue);
			Main.tileSolid[Type] = true;
            drop = ItemID.SoulofNight;
            dustType = ModContent.DustType<Dusts.Dust229>();
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            int p = Player.FindClosest(new Vector2(i, j), 24, 24);
            if (p != 255)
            {
                if (WorldGen.tileCounts[Type] > 15)
                {
                    Main.player[p].wolfAcc = true;
                }
            }
            base.NearbyEffects(i, j, closer);
        }
    }
}