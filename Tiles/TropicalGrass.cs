using Microsoft.Xna.Framework;
            Main.tileSolid[Type] = true;
            // do drop
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