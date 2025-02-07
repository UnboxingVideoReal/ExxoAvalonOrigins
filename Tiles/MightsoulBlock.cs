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
	public class MightsoulBlock : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(Color.Blue);
			Main.tileSolid[Type] = true;
			drop = ItemID.SoulofMight;
            dustType = ModContent.DustType<Dusts.Dust231>();
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            int p = Player.FindClosest(new Vector2(i, j), 24, 24);
            if (p != 255)
            {
                if (WorldGen.tileCounts[Type] > 15)
                {
                    Main.player[p].meleeDamage += 0.1f;
                    Main.player[p].rangedDamage += 0.1f;
                    Main.player[p].magicDamage += 0.1f;
                    Main.player[p].minionDamage += 0.1f;
                    Main.player[p].thrownDamage += 0.1f;
                }
            }
            base.NearbyEffects(i, j, closer);
        }
    }
}