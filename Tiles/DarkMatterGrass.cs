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
	public class DarkMatterGrass : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(120, 15, 170));
			Main.tileSolid[Type] = true;
			Main.tileBrick[Type] = true;
			Main.tileBlockLight[Type] = true;
            Main.tileBlendAll[Type] = true;
            drop = mod.ItemType("DarkMatterGrass");
            dustType = ModContent.DustType<Dusts.DarkMatterDust>();
		}

        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return ModContent.TileType<DarkMatterSapling>();
        }

        public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (!fail)
            {
                ExxoAvalonOriginsWorld.WorldDarkMatterTiles--;
            }
            base.KillTile(i, j, ref fail, ref effectOnly, ref noItem);
        }
    }
}