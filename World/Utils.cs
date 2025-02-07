﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ExxoAvalonOrigins.Tiles;
using Microsoft.Xna.Framework;

namespace ExxoAvalonOrigins.World
{
    class Utils
    {
        public static void SquareTileFrame(int i, int j, bool resetFrame = true, bool resetSlope = false, bool largeHerb = false)
        {
            if (resetSlope)
            {
                Main.tile[i, j].slope(0);
                Main.tile[i, j].halfBrick(false);
            }
            WorldGen.TileFrame(i - 1, j - 1, false, largeHerb);
            WorldGen.TileFrame(i - 1, j, false, largeHerb);
            WorldGen.TileFrame(i - 1, j + 1, false, largeHerb);
            WorldGen.TileFrame(i, j - 1, false, largeHerb);
            WorldGen.TileFrame(i, j, resetFrame, largeHerb);
            WorldGen.TileFrame(i, j + 1, false, largeHerb);
            WorldGen.TileFrame(i + 1, j - 1, false, largeHerb);
            WorldGen.TileFrame(i + 1, j, false, largeHerb);
            WorldGen.TileFrame(i + 1, j + 1, false, largeHerb);
        }
        /// <summary>
        /// A helper method to run WorldGen.SquareTileFrame() over an area.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="r">The radius.</param>
        /// <param name="lh">Whether or not to use Large Herb logic.</param>
        public static void SquareTileFrameArea(int x, int y, int r, bool lh = false)
        {
            for (var i = x - r; i < x + r; i++)
            {
                for (var j = y - r; j < y + r; j++)
                {
                    SquareTileFrame(i, j, true, lh);
                }
            }
        }
        /// <summary>
        /// Swaps two values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lhs">Left hand side.</param>
        /// <param name="rhs">Right hand side.</param>
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T t = lhs;
            lhs = rhs;
            rhs = t;
        }
        /// <summary>
        /// A helper method to find the actual surface of the world.
        /// </summary>
        /// <param name="positionX">The x position.</param>
        /// <returns></returns>
        public static int TileCheck(int positionX)
        {
            for (int i = (int)(WorldGen.worldSurfaceLow - 30); i < Main.maxTilesY; i++)
            {
                Tile tile = Framing.GetTileSafely(positionX, i);
                if ((tile.type == TileID.Dirt || tile.type == TileID.ClayBlock || tile.type == TileID.Stone || tile.type == TileID.Sand || tile.type == ModContent.TileType<Snotsand>() || tile.type == ModContent.TileType<TropicalMud>() || tile.type == TileID.Mud || tile.type == TileID.SnowBlock || tile.type == TileID.IceBlock) && tile.active())
                {
                    return i;
                }
            }
            return 0;
        }

        public static void MakeCircle(int x, int y, int radius, int tileType, bool walls = false, int wallType = WallID.Dirt)
        {
            for (int k = x - radius; k <= x + radius; k++)
            {
                for (int l = y - radius; l <= y + radius; l++)
                {
                    float dist = Vector2.Distance(new Vector2(k, l), new Vector2(x, y));
                    if (dist <= radius && dist >= (radius - 29))
                    {
                        Main.tile[k, l].active(false);
                    }
                    if ((dist <= radius && dist >= radius - 7) || (dist <= (float)(radius - 22) && dist >= (float)(radius - 29)))
                    {
                        Main.tile[k, l].active(true);
                        Main.tile[k, l].halfBrick(false);
                        Main.tile[k, l].slope(0);
                        Main.tile[k, l].type = (ushort)tileType;
                        WorldGen.SquareTileFrame(k, l);
                    }
                    if (walls)
                    {
                        if (dist <= radius - 6 && dist >= radius - 23)
                        {
                            Main.tile[k, l].wall = (ushort)wallType;
                        }
                    }
                }
            }
        }
    }
}
