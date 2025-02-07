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
	public class TropicalGrass : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(56, 215, 29));
            SetModTree(new TropicalTree());
            Main.tileSolid[Type] = true;
			Main.tileBrick[Type] = true;
			Main.tileBlockLight[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileMergeDirt[Type] = true;
            drop = ModContent.ItemType<Items.TropicalMudBlock>();
            // do drop
        }

        public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (fail && !effectOnly)
            {
                Main.tile[i, j].type = (ushort)ModContent.TileType<TropicalMud>();
                WorldGen.SquareTileFrame(i, j);
            }
        }
        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return ModContent.TileType<TropicalSapling>();
        }
    }
}