﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.World.Generation;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ExxoAvalonOrigins.World.Passes
{
    class TuhrtlOutpost
    {
        public static void Method(GenerationProgress progress)
        {
            progress.Message = "Generating Tuhrtl Outpost";
            bool flag30 = true;
            while (flag30)
            {
                int num406 = WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY - 500);
                int num407 = ((ExxoAvalonOriginsWorld.dungeonSide >= 0) ? WorldGen.genRand.Next((int)(Main.maxTilesX * 0.15), (int)(Main.maxTilesX * 0.4)) : WorldGen.genRand.Next((int)(Main.maxTilesX * 0.6), (int)(Main.maxTilesX * 0.85)));
                if (Main.tile[num407, num406].active() && Main.tile[num407, num406].type == (ushort)ModContent.TileType<Tiles.TropicalGrass>())
                {
                    flag30 = false;
                    Structures.TuhrtlOutpost.CreateTuhrtlOutpost(num407, num406);
                }
            }
        }
    }
}
