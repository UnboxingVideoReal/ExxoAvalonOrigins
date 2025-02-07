﻿using Terraria;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace ExxoAvalonOrigins.World.Passes
{
    class ContagionVines
    {
        public static void Method(GenerationProgress progress)
        {
            for (int num586 = 0; num586 < Main.maxTilesX; num586++)
            {
                int num587 = 0;
                for (int num589 = 0; num589 < Main.maxTilesY; num589++)
                {
                    if (num587 > 0 && !Main.tile[num586, num589].active())
                    {
                        Main.tile[num586, num589].active(true);
                        Main.tile[num586, num589].type = (ushort)ModContent.TileType<Tiles.ContagionVines>();
                        num587--;
                    }
                    else
                    {
                        num587 = 0;
                    }
                    if (Main.tile[num586, num589].active() && Main.tile[num586, num589].type == (ushort)ModContent.TileType<Tiles.Ickgrass>() && !Main.tile[num586, num589].bottomSlope() && WorldGen.genRand.Next(5) < 3)
                    {
                        num587 = WorldGen.genRand.Next(1, 10);
                    }
                }
            }
        }
    }
}
