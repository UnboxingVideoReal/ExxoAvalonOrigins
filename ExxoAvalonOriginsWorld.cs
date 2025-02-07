﻿using ExxoAvalonOrigins.Items;
using ExxoAvalonOrigins.World;
using ExxoAvalonOrigins.Tiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Terraria;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.World.Generation;
using Utils = ExxoAvalonOrigins.World.Utils;

namespace ExxoAvalonOrigins
{
    public class ExxoAvalonOriginsWorld : ModWorld
    {
        public static int shmOreTier1 = -1;
        public static int shmOreTier2 = -1;
        public static int hallowAltarCount;
        public static bool contaigon = false;
        public static int WorldDarkMatterTiles = 0;
        public static int hallowedAltarCount = 0;
        public static bool stopCometDrops = false;
        public static Vector2 hiddenTemplePos;
        public static bool retroGenned = false;
        public static bool jungleLocationKnown = false;
        public static bool generatingBaccilite = false;
        public static int dungeonSide = 0;
        public static int jungleX = 0;
        public static int grassSpread = 0;
        public static bool contaigonSet = false;
        public static int hellcastleTiles = 0;
        public static int ickyTiles = 0;
        public static int darkTiles = 0;
        public static int tropicTiles = 0;
        public static int caesiumTiles = 0;
        public static Vector2 LoK = Vector2.Zero;
        public static int wosT;
        public static int wosB;
        public static int wosF = 0;
        public static int wos = -1;
        public static bool downedBacteriumPrime = false;
        public static bool downedDesertBeak = false;
        public static bool downedPhantasm = false;
        public static bool downedDragonLord = false;
        public static bool downedMechasting = false;
        public static bool downedOblivion = false;
        public static bool downedKingSting = false;

        #region WorldGen Variants
        public enum JungleVariant
        {
            jungle,
            tropics,
            random
        }

        public enum CopperVariant
        {
            copper,
            tin,
            bronze,
            random
        }

        public enum IronVariant
        {
            iron,
            lead,
            nickel,
            random
        }
        public enum SilverVariant
        {
            silver,
            tungsten,
            zinc,
            random
        }
        public enum GoldVariant
        {
            gold,
            platinum,
            bismuth,
            random
        }

        public enum RhodiumVariant
        {
            rhodium,
            osmium,
            iridium,
            random
        }

        public enum CobaltVariant
        {
            cobalt,
            palladium,
            duratanium,
            random
        }

        public enum MythrilVariant
        {
            mythril,
            orichalcum,
            naquadah,
            random
        }

        public enum AdamantiteVariant
        {
            adamantite,
            titanium,
            troxinium,
            random
        }

        public enum SHMTier1Variant
        {
            tritanorium,
            pyroscoric,
            random
        }

        public enum SHMTier2Variant
        {
            unvolandite,
            vorazylcum,
            random
        }

        public static JungleVariant jungleMenuSelection = JungleVariant.random;
        public static CopperVariant copperOre = CopperVariant.random;
        public static IronVariant ironOre = IronVariant.random;
        public static SilverVariant silverOre = SilverVariant.random;
        public static GoldVariant goldOre = GoldVariant.random;
        public static RhodiumVariant rhodiumOre = RhodiumVariant.random;
        public static CobaltVariant cobaltOre = CobaltVariant.random;
        public static MythrilVariant mythrilOre = MythrilVariant.random;
        public static AdamantiteVariant adamantiteOre = AdamantiteVariant.random;
        public static SHMTier1Variant shmTier1Ore = SHMTier1Variant.random;
        public static SHMTier2Variant shmTier2Ore = SHMTier2Variant.random;
        #endregion

        public override void ChooseWaterStyle(ref int style)
        {
            if (Main.LocalPlayer.GetModPlayer<ExxoAvalonOriginsModPlayer>().zoneBooger)
                style = ModContent.GetInstance<Waters.ContagionWaterStyle>().Type;
            if (Main.LocalPlayer.GetModPlayer<ExxoAvalonOriginsModPlayer>().zoneTropics)
                style = ModContent.GetInstance<Waters.TropicsWaterStyle>().Type;
        }
        public override void TileCountsAvailable(int[] tileCounts)
        {
            Main.jungleTiles += tileCounts[ModContent.TileType<GreenIce>()];
            ickyTiles = tileCounts[ModContent.TileType<Chunkstone>()] + tileCounts[ModContent.TileType<HardenedSnotsand>()] + tileCounts[ModContent.TileType<Snotsandstone>()] + tileCounts[ModContent.TileType<Ickgrass>()] + tileCounts[ModContent.TileType<Snotsand>()] + tileCounts[ModContent.TileType<YellowIce>()];
            tropicTiles = tileCounts[ModContent.TileType<TropicalStone>()] + tileCounts[ModContent.TileType<Tiles.TuhrtlBrick>()] + tileCounts[ModContent.TileType<TropicalMud>()] + tileCounts[ModContent.TileType<TropicalGrass>()];
            hellcastleTiles = tileCounts[ModContent.TileType<Tiles.ImperviousBrick>()];
            darkTiles = tileCounts[ModContent.TileType<Tiles.DarkMatter>()] + tileCounts[ModContent.TileType<Tiles.DarkMatterSand>()] + tileCounts[ModContent.TileType<Tiles.BlackIce>()] + tileCounts[ModContent.TileType<Tiles.DarkMatterSoil>()] + tileCounts[ModContent.TileType<Tiles.HardenedDarkSand>()] + tileCounts[ModContent.TileType<Tiles.Darksandstone>()] + tileCounts[ModContent.TileType<Tiles.DarkMatterGrass>()];
            caesiumTiles = tileCounts[ModContent.TileType<Tiles.BlackBlaststone>()];
            Main.sandTiles += tileCounts[ModContent.TileType<Snotsand>()];
        }

        public void RetroGen()
        {
            if (ExxoAvalonOrigins.lastOpenedVersion < new Version(0, 1, 0, 0))
            {
                rhodiumOre = (RhodiumVariant)WorldGen.genRand.Next(2);
                for (var num156 = 0; num156 < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00012); num156++)
                {
                    var i10 = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                    var rockLayer3 = Main.rockLayer;
                    var j10 = WorldGen.genRand.Next((int)rockLayer3, Main.maxTilesY - 150);
                    WorldGen.OreRunner(i10, j10, WorldGen.genRand.Next(4, 5), WorldGen.genRand.Next(5, 7), (ushort)rhodiumOre.GetTile());
                }
                Main.NewText("Retrogenned Rhodium/Osmium/Iridium");
                //Caesium
                for (var num179 = 0; num179 < (int)((Main.maxTilesX * Main.maxTilesY) * 0.0008); num179++)
                {
                    WorldGen.OreRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next(Main.maxTilesY - 150, Main.maxTilesY), WorldGen.genRand.Next(2, 6), WorldGen.genRand.Next(3, 5), (ushort)ModContent.TileType<Tiles.CaesiumOre>());
                    //WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next(Main.maxTilesY - 150, Main.maxTilesY), WorldGen.genRand.Next(2, 6), WorldGen.genRand.Next(3, 5), ModContent.TileType<CaesiumOre>(), false, 0f, 0f, false, true);
                }
                Main.NewText("Retrogenned Caesium");
            }
            if (ExxoAvalonOrigins.lastOpenedVersion < new Version(0, 1, 1, 0))
            {
                for (var num284 = 69; num284 < 72; num284++)
                {
                    var type8 = 0;
                    float num285 = 0;
                    if (num284 == 69)
                    {
                        type8 = ModContent.TileType<Tiles.Tourmaline>();
                        num285 = Main.maxTilesX * 0.2f;
                    }
                    else if (num284 == 70)
                    {
                        type8 = ModContent.TileType<Tiles.Peridot>();
                        num285 = Main.maxTilesX * 0.2f;
                    }
                    else if (num284 == 71)
                    {
                        type8 = ModContent.TileType<Tiles.Zircon>();
                        num285 = Main.maxTilesX * 0.2f;
                    }
                    num285 *= 0.2f;
                    var num286 = 0;
                    while (num286 < num285)
                    {
                        var num287 = WorldGen.genRand.Next(0, Main.maxTilesX);
                        var num288 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY);
                        while (Main.tile[num287, num288].type != 1)
                        {
                            num287 = WorldGen.genRand.Next(0, Main.maxTilesX);
                            num288 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY);
                        }
                        WorldGen.TileRunner(num287, num288, WorldGen.genRand.Next(2, 6), WorldGen.genRand.Next(3, 7), type8, false, 0f, 0f, false, true);
                        num286++;
                    }
                }
                Main.NewText("Retrogenned Tourmaline, Peridot and Zircon");
            }
            if (ExxoAvalonOrigins.lastOpenedVersion < new Version(0, 3, 0, 0))
            {
                for (var i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 2E-05); i++)
                {
                    var i8 = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                    var rockLayer = Main.rockLayer;
                    var j8 = WorldGen.genRand.Next((int)rockLayer, Main.maxTilesY - 150);
                    World.Passes.OreGenPreHardMode.GenerateHearts(i8, j8, ModContent.TileType<Tiles.Heartstone>());
                }
                Main.NewText("Retrogenned Heartstone");
            }
            if (ExxoAvalonOrigins.lastOpenedVersion < new Version(0, 3, 0, 0))
            {
                for (var num721 = 0; num721 < 3; num721++)
                {
                    var x10 = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
                    var y6 = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY - 300);
                    World.Structures.IceShrine.Generate(x10, y6);
                }
                Main.NewText("Retrogenned Ice Shrines");
            }
        }
        public static void CheckLargeHerb(int x, int y, int type)
        {
            if (WorldGen.destroyObject)
            {
                return;
            }
            Tile t = Main.tile[x, y];
            int style = (int)(t.frameX / 18);
            bool destroy = false;
            int fixedY = y;
            int yframe = (int)Main.tile[x, y].frameY;
            fixedY -= yframe / 18;
            if (!WorldGen.SolidTile2(x, fixedY + 3) || !Main.tile[x, fixedY].active() ||
                !Main.tile[x, fixedY + 1].active() || !Main.tile[x, fixedY + 2].active())
            {
                destroy = true;
            }
            if (destroy)
            {
                WorldGen.destroyObject = true;
                for (int u = fixedY; u < fixedY + 3; u++)
                {
                    WorldGen.KillTile(x, u, false, false, false);
                }
                if (type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage1>() || type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>() ||
                    type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>()) // 469 through 471 are the immature tiles of the large herb; 472 is the mature version
                {
                    int item = 0;
                    switch (style)
                    {
                        case 0:
                            item = ModContent.ItemType<Items.LargeDaybloomSeed>();
                            break;
                        case 1:
                            item = ModContent.ItemType<Items.LargeMoonglowSeed>();
                            break;
                        case 2:
                            item = ModContent.ItemType<Items.LargeBlinkrootSeed>();
                            break;
                        case 3:
                            item = ModContent.ItemType<Items.LargeDeathweedSeed>();
                            break;
                        case 4:
                            item = ModContent.ItemType<Items.LargeWaterleafSeed>();
                            break;
                        case 5:
                            item = ModContent.ItemType<Items.LargeFireblossomSeed>();
                            break;
                        case 6:
                            item = ModContent.ItemType<Items.LargeShiverthornSeed>();
                            break;
                        case 7:
                            item = ModContent.ItemType<Items.LargeBloodberrySeed>();
                            break;
                        case 8:
                            item = ModContent.ItemType<Items.LargeSweetstemSeed>();
                            break;
                        case 9:
                            item = ModContent.ItemType<Items.LargeBarfbushSeed>();
                            break;
                    }// 3710 through 3719 are the seeds
                    if (item > 0) Item.NewItem(x * 16, fixedY * 16, 16, 48, item);
                }
                else
                {
                    int item = 0;
                    switch (style)
                    {
                        case 0:
                            item = ModContent.ItemType<Items.LargeDaybloom>();
                            break;
                        case 1:
                            item = ModContent.ItemType<Items.LargeMoonglow>();
                            break;
                        case 2:
                            item = ModContent.ItemType<Items.LargeBlinkroot>();
                            break;
                        case 3:
                            item = ModContent.ItemType<Items.LargeDeathweed>();
                            break;
                        case 4:
                            item = ModContent.ItemType<Items.LargeWaterleaf>();
                            break;
                        case 5:
                            item = ModContent.ItemType<Items.LargeFireblossom>();
                            break;
                        case 6:
                            item = ModContent.ItemType<Items.LargeShiverthorn>();
                            break;
                        case 7:
                            item = ModContent.ItemType<Items.LargeBloodberry>();
                            break;
                        case 8:
                            item = ModContent.ItemType<Items.LargeSweetstem>();
                            break;
                        case 9:
                            item = ModContent.ItemType<Items.LargeBarfbush>();
                            break;
                    }
                    if (item > 0) Item.NewItem(x * 16, fixedY * 16, 16, 48, item);
                    // 3700 through 3709 are the large herbs
                }
                WorldGen.destroyObject = false;
            }
        }
        public static void ConvertFromThings(int x, int y, int convert, bool tileframe = true)
        {
            Tile tile = Main.tile[x, y];
            int type = tile.type;
            int wall = tile.wall;
            if (!WorldGen.InWorld(x, y, 1))
            {
                return;
            }
            if (convert == 0)
            {
                if (Main.tile[x, y] != null)
                {
                    if (wall == ModContent.WallType<Walls.ContagionGrassWall>())
                    {
                        Main.tile[x, y].wall = WallID.GrassUnsafe;
                    }
                    else if (wall == ModContent.WallType<Walls.ChunkstoneWall>())
                    {
                        Main.tile[x, y].wall = WallID.Stone;
                    }
                }
                if (Main.tile[x, y] != null)
                {
                    if (type == ModContent.TileType<Ickgrass>())
                    {
                        tile.type = TileID.Grass;
                    }
                    else if (type == ModContent.TileType<YellowIce>())
                    {
                        tile.type = TileID.IceBlock;
                    }
                    else if (type == ModContent.TileType<Snotsand>())
                    {
                        tile.type = TileID.Sand;
                    }
                    else if (type == ModContent.TileType<Chunkstone>())
                    {
                        tile.type = TileID.Stone;
                    }
                    else if (type == ModContent.TileType<Snotsandstone>())
                    {
                        tile.type = TileID.Sandstone;
                    }
                    else if (type == ModContent.TileType<HardenedSnotsand>())
                    {
                        tile.type = TileID.HardenedSand;
                    }
                    //else if (type == ModContent.TileType<ContagionShortGrass>())
                    //{
                    //    tile.type = TileID.Plants;
                    //}
                    if (TileID.Sets.Conversion.Grass[type] || type == 0)
                    {
                        WorldGen.SquareTileFrame(x, y);
                    }
                }
            }
            if (convert == 1)
            {
                if (Main.tile[x, y] != null)
                {
                    if (wall == ModContent.WallType<Walls.ContagionGrassWall>() || wall == WallID.CrimsonGrassUnsafe || wall == WallID.CorruptGrassUnsafe || wall == WallID.HallowedGrassUnsafe)
                    {
                        Main.tile[x, y].wall = WallID.JungleUnsafe;
                    }
                    else if (wall == WallID.DirtUnsafe)
                    {
                        Main.tile[x, y].wall = WallID.MudUnsafe;
                    }
                }
                if (Main.tile[x, y] != null)
                {
                    if (type == ModContent.TileType<Ickgrass>() || type == TileID.FleshGrass || type == TileID.CorruptGrass || type == TileID.Grass || type == TileID.HallowedGrass)
                    {
                        tile.type = TileID.JungleGrass;
                    }
                    else if (type == TileID.Dirt)
                    {
                        tile.type = TileID.Mud;
                    }
                    else if (type == ModContent.TileType<Snotsand>() || type == TileID.Sand || type == TileID.Crimsand || type == TileID.Ebonsand || type == TileID.Pearlsand)
                    {
                        tile.type = TileID.Sand;
                    }
                    else if (type == ModContent.TileType<Chunkstone>() || type == TileID.Pearlstone || type == TileID.Crimstone || type == TileID.Ebonstone)
                    {
                        tile.type = TileID.Stone;
                    }
                    else if (type == ModContent.TileType<Snotsandstone>() || type == TileID.HallowSandstone || type == TileID.CrimsonSandstone || type == TileID.CorruptSandstone)
                    {
                        tile.type = TileID.Sandstone;
                    }
                    else if (type == ModContent.TileType<HardenedSnotsand>() || type == TileID.HallowHardenedSand || type == TileID.CrimsonHardenedSand || type == TileID.CorruptHardenedSand)
                    {
                        tile.type = TileID.HardenedSand;
                    }
                    else if (type == ModContent.TileType<YellowIce>() || type == TileID.HallowedIce || type == TileID.FleshIce || type == TileID.CorruptIce || type == TileID.IceBlock)
                    {
                        tile.type = (ushort)ModContent.TileType<GreenIce>();
                    }
                    if (TileID.Sets.Conversion.Grass[type] || type == 0)
                    {
                        WorldGen.SquareTileFrame(x, y);
                    }
                }
            }
            if (tileframe)
            {
                if (Main.netMode == NetmodeID.SinglePlayer)
                {
                    WorldGen.SquareTileFrame(x, y);
                }
                else if (Main.netMode == NetmodeID.Server)
                {
                    NetMessage.SendTileSquare(-1, x, y, 1);
                }
            }
        }

        public override void ModifyHardmodeTasks(List<GenPass> list)
        {
            int index = list.FindIndex(genpass => ((string)genpass.Name).Equals("Hardmode Good"));
            int index2 = list.FindIndex(genpass => ((string)genpass.Name).Equals("Hardmode Evil"));
            int index3 = list.FindIndex(genpass => ((string)genpass.Name).Equals(""));
            if (contaigon)
            {
                list.Insert(index + 1, (GenPass)new PassLegacy("Exxo Avalon Origins: Hardmode Contagion", new WorldGenLegacyMethod(World.Passes.ContagionHardMode.Method)));
                // TODO REPLACE EVIL GEN INSTEAD OF REMOVING
                list.RemoveAt(index);
                list.RemoveAt(index2);
            }
            list.Insert(index + 2, (GenPass)new PassLegacy("Hardmode snow ore generation", new WorldGenLegacyMethod(World.Passes.SnowHardMode.Method)));
        }

        public override void NetSend(BinaryWriter writer)
        {
            var flags = new BitsByte();
            flags[0] = ExxoAvalonOrigins.superHardmode;
            flags[1] = downedPhantasm;
            flags[2] = contaigon;
            flags[3] = downedBacteriumPrime;
            flags[4] = downedDesertBeak;
            flags[5] = downedDragonLord;
            flags[6] = downedMechasting;
            flags[7] = downedOblivion;
            writer.Write(flags);
            writer.WriteVector2(LoK);
            writer.Write(ExxoAvalonOrigins.dungeonEx);
            writer.Write(shmOreTier1);
            writer.Write(shmOreTier2);
            writer.Write(hallowAltarCount);
        }
        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            ExxoAvalonOrigins.superHardmode = flags[0];
            downedBacteriumPrime = flags[3];
            downedDesertBeak = flags[4];
            downedPhantasm = flags[1];
            downedDragonLord = flags[5];
            downedMechasting = flags[6];
            downedOblivion = flags[7];
            contaigon = flags[2];
            LoK = reader.ReadVector2();
            ExxoAvalonOrigins.dungeonEx = reader.ReadInt32();
            shmOreTier1 = reader.ReadInt32();
            shmOreTier2 = reader.ReadInt32();
            hallowAltarCount = reader.ReadInt32();
        }
        public static void GrowLargeHerb(int x, int y)
        {
            if (Main.tile[x, y].active())
            {
                if (Main.tile[x, y].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage1>() && WorldGen.genRand.Next(8) == 0) // phase 1 to 2
                {
                    bool grow = false;
                    if (Main.tile[x, y].frameX == 108) // shiverthorn check
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            grow = true;
                        }
                    }
                    else
                    {
                        grow = true;
                    }
                    if (grow)
                    {
                        Main.tile[x, y].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>();
                        if (Main.tile[x, y + 1].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage1>()) Main.tile[x, y + 1].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>();
                        if (Main.tile[x, y + 2].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage1>()) Main.tile[x, y + 2].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>();
                        if (Main.tile[x, y - 1].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage1>()) Main.tile[x, y - 1].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>();
                        if (Main.tile[x, y - 2].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage1>()) Main.tile[x, y - 2].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>();
                        if (Main.netMode == NetmodeID.Server)
                        {
                            NetMessage.SendTileSquare(-1, x, y, 2);
                            NetMessage.SendTileSquare(-1, x, y + 1, 2);
                            NetMessage.SendTileSquare(-1, x, y + 2, 2);
                            NetMessage.SendTileSquare(-1, x, y - 1, 2);
                            NetMessage.SendTileSquare(-1, x, y - 2, 2);
                        }
                        World.Utils.SquareTileFrameArea(x, y, 4, true);
                        return;
                    }
                }
                else if (Main.tile[x, y].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>() && WorldGen.genRand.Next(7) == 0) // phase 2 to 3
                {
                    bool grow = false;
                    if (Main.tile[x, y].frameX == 108) // shiverthorn check
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            grow = true;
                        }
                    }
                    else
                    {
                        grow = true;
                    }
                    if (grow)
                    {
                        Main.tile[x, y].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>();
                        if (Main.tile[x, y + 1].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>()) Main.tile[x, y + 1].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>();
                        if (Main.tile[x, y + 2].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>()) Main.tile[x, y + 2].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>();
                        if (Main.tile[x, y - 1].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>()) Main.tile[x, y - 1].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>();
                        if (Main.tile[x, y - 2].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>()) Main.tile[x, y - 2].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>();
                        if (Main.netMode == NetmodeID.Server)
                        {
                            NetMessage.SendTileSquare(-1, x, y, 2);
                            NetMessage.SendTileSquare(-1, x, y + 1, 2);
                            NetMessage.SendTileSquare(-1, x, y + 2, 2);
                            NetMessage.SendTileSquare(-1, x, y - 1, 2);
                            NetMessage.SendTileSquare(-1, x, y - 2, 2);
                        }
                        World.Utils.SquareTileFrameArea(x, y, 4, true);
                        return;
                    }
                }
                else if (Main.tile[x, y].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>() && WorldGen.genRand.Next(5) == 0) // phase 3 to 4
                {
                    Main.tile[x, y].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage4>();
                    if (Main.tile[x, y + 1].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>()) Main.tile[x, y + 1].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage4>();
                    if (Main.tile[x, y + 2].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>()) Main.tile[x, y + 2].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage4>();
                    if (Main.tile[x, y - 1].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>()) Main.tile[x, y - 1].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage4>();
                    if (Main.tile[x, y - 2].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>()) Main.tile[x, y - 2].type = (ushort)ModContent.TileType<Tiles.LargeHerbsStage4>();
                    if (Main.netMode == NetmodeID.Server)
                    {
                        NetMessage.SendTileSquare(-1, x, y, 2);
                        NetMessage.SendTileSquare(-1, x, y + 1, 2);
                        NetMessage.SendTileSquare(-1, x, y + 2, 2);
                        NetMessage.SendTileSquare(-1, x, y - 1, 2);
                        NetMessage.SendTileSquare(-1, x, y - 2, 2);
                    }
                    World.Utils.SquareTileFrameArea(x, y, 4, true);
                    return;
                }
            }
        }

        public static void DarkMatterSpread(int i, int j)
        {
            if (!Main.hardMode || Main.tile[i, j].inActive()) return;
            int type = Main.tile[i, j].type;
            if (ExxoAvalonOrigins.superHardmode)
            {
                if (type == ModContent.TileType<Tiles.DarkMatter>() || type == ModContent.TileType<Tiles.DarkMatterSoil>() || type == ModContent.TileType<DarkMatterGrass>() || type == ModContent.TileType<DarkMatterSand>() || type == ModContent.TileType<HardenedDarkSand>() || type == ModContent.TileType<Darksandstone>() || type == ModContent.TileType<BlackIce>())
                {
                    bool flag5 = true;
                    while (flag5)
                    {
                        flag5 = false;
                        int num6 = i + WorldGen.genRand.Next(-3, 4);
                        int num7 = j + WorldGen.genRand.Next(-3, 4);
                        if (Main.tile[num6, num7 - 1].type == 27)
                        {
                            continue;
                        }
                        if (Main.tile[num6, num7].type == 2)
                        {
                            if (WorldGen.genRand.Next(2) == 0)
                            {
                                flag5 = true;
                            }
                            Main.tile[num6, num7].type = (ushort)ModContent.TileType<Ickgrass>();
                            WorldGen.SquareTileFrame(num6, num7);
                            NetMessage.SendTileSquare(-1, num6, num7, 1);
                        }
                        else if (Main.tile[num6, num7].type == TileID.Stone || Main.tile[num6, num7].type == TileID.Crimstone || Main.tile[num6, num7].type == TileID.Ebonstone || Main.tile[num6, num7].type == TileID.Pearlstone || Main.tile[num6, num7].type == (ushort)ModContent.TileType<Chunkstone>() || Main.tileMoss[Main.tile[num6, num7].type])
                        {
                            if (WorldGen.genRand.Next(2) == 0)
                            {
                                flag5 = true;
                            }
                            Main.tile[num6, num7].type = (ushort)ModContent.TileType<DarkMatter>();
                            WorldGen.SquareTileFrame(num6, num7);
                            NetMessage.SendTileSquare(-1, num6, num7, 1);
                        }
                        else if (Main.tile[num6, num7].type == TileID.Sand || Main.tile[num6, num7].type == TileID.Pearlsand || Main.tile[num6, num7].type == TileID.Ebonsand || Main.tile[num6, num7].type == TileID.Crimsand || Main.tile[num6, num7].type == (ushort)ModContent.TileType<Snotsand>())
                        {
                            if (WorldGen.genRand.Next(2) == 0)
                            {
                                flag5 = true;
                            }
                            Main.tile[num6, num7].type = (ushort)ModContent.TileType<Tiles.DarkMatterSand>();
                            WorldGen.SquareTileFrame(num6, num7);
                            NetMessage.SendTileSquare(-1, num6, num7, 1);
                        }
                        else if (Main.tile[num6, num7].type == TileID.Sandstone || Main.tile[num6, num7].type == TileID.CrimsonSandstone || Main.tile[num6, num7].type == TileID.CorruptSandstone || Main.tile[num6, num7].type == TileID.HallowSandstone || Main.tile[num6, num7].type == (ushort)ModContent.TileType<Snotsandstone>())
                        {
                            if (WorldGen.genRand.Next(2) == 0)
                            {
                                flag5 = true;
                            }
                            Main.tile[num6, num7].type = (ushort)ModContent.TileType<Darksandstone>();
                            WorldGen.SquareTileFrame(num6, num7);
                            NetMessage.SendTileSquare(-1, num6, num7, 1);
                        }
                        else if (Main.tile[num6, num7].type == TileID.HardenedSand || Main.tile[num6, num7].type == TileID.CrimsonHardenedSand || Main.tile[num6, num7].type == TileID.CorruptHardenedSand || Main.tile[num6, num7].type == TileID.HallowHardenedSand || Main.tile[num6, num7].type == (ushort)ModContent.TileType<HardenedSnotsand>())
                        {
                            if (WorldGen.genRand.Next(2) == 0)
                            {
                                flag5 = true;
                            }
                            Main.tile[num6, num7].type = (ushort)ModContent.TileType<HardenedDarkSand>();
                            WorldGen.SquareTileFrame(num6, num7);
                            NetMessage.SendTileSquare(-1, num6, num7, 1);
                        }
                        else if (Main.tile[num6, num7].type == TileID.IceBlock || Main.tile[num6, num7].type == TileID.FleshIce || Main.tile[num6, num7].type == TileID.CorruptIce || Main.tile[num6, num7].type == TileID.HallowedIce || Main.tile[num6, num7].type == (ushort)ModContent.TileType<YellowIce>())
                        {
                            if (WorldGen.genRand.Next(2) == 0)
                            {
                                flag5 = true;
                            }
                            Main.tile[num6, num7].type = (ushort)ModContent.TileType<BlackIce>();
                            WorldGen.SquareTileFrame(num6, num7);
                            NetMessage.SendTileSquare(-1, num6, num7, 1);
                        }
                    }
                }
            }
        }
        public static void ContagionHardmodeSpread(int i, int j)
        {
            if (!Main.hardMode || Main.tile[i, j].inActive())
            {
                return;
            }
            int type = Main.tile[i, j].type;
            if (type == ModContent.TileType<Tiles.Chunkstone>() || type == ModContent.TileType<Ickgrass>() || type == ModContent.TileType<Snotsand>() || type == ModContent.TileType<HardenedSnotsand>() || type == ModContent.TileType<Snotsandstone>() || type == ModContent.TileType<YellowIce>())
            {
                bool flag5 = true;
                while (flag5)
                {
                    flag5 = false;
                    int num6 = i + WorldGen.genRand.Next(-3, 4);
                    int num7 = j + WorldGen.genRand.Next(-3, 4);
                    //bool flag6 = NearbyChlorophyte(num6, num7);
                    if (Main.tile[num6, num7 - 1].type == 27)
                    {
                        continue;
                    }
                    if (Main.tile[num6, num7].type == 2)
                    {
                        if (WorldGen.genRand.Next(2) == 0)
                        {
                            flag5 = true;
                        }
                        Main.tile[num6, num7].type = (ushort)ModContent.TileType<Ickgrass>();
                        WorldGen.SquareTileFrame(num6, num7);
                        NetMessage.SendTileSquare(-1, num6, num7, 1);
                    }
                    else if (Main.tile[num6, num7].type == 1 || Main.tileMoss[Main.tile[num6, num7].type])
                    {
                        if (WorldGen.genRand.Next(2) == 0)
                        {
                            flag5 = true;
                        }
                        Main.tile[num6, num7].type = (ushort)ModContent.TileType<Chunkstone>();
                        WorldGen.SquareTileFrame(num6, num7);
                        NetMessage.SendTileSquare(-1, num6, num7, 1);
                    }
                    else if (Main.tile[num6, num7].type == 53)
                    {
                        if (WorldGen.genRand.Next(2) == 0)
                        {
                            flag5 = true;
                        }
                        Main.tile[num6, num7].type = (ushort)ModContent.TileType<Snotsand>();
                        WorldGen.SquareTileFrame(num6, num7);
                        NetMessage.SendTileSquare(-1, num6, num7, 1);
                    }
                    else if (Main.tile[num6, num7].type == 396)
                    {
                        if (WorldGen.genRand.Next(2) == 0)
                        {
                            flag5 = true;
                        }
                        Main.tile[num6, num7].type = (ushort)ModContent.TileType<Snotsandstone>();
                        WorldGen.SquareTileFrame(num6, num7);
                        NetMessage.SendTileSquare(-1, num6, num7, 1);
                    }
                    else if (Main.tile[num6, num7].type == 397)
                    {
                        if (WorldGen.genRand.Next(2) == 0)
                        {
                            flag5 = true;
                        }
                        Main.tile[num6, num7].type = (ushort)ModContent.TileType<HardenedSnotsand>();
                        WorldGen.SquareTileFrame(num6, num7);
                        NetMessage.SendTileSquare(-1, num6, num7, 1);
                    }
                    else if (Main.tile[num6, num7].type == 161)
                    {
                        if (WorldGen.genRand.Next(2) == 0)
                        {
                            flag5 = true;
                        }
                        Main.tile[num6, num7].type = (ushort)ModContent.TileType<YellowIce>();
                        WorldGen.SquareTileFrame(num6, num7);
                        NetMessage.SendTileSquare(-1, num6, num7, 1);
                    }
                }
            }
        }
        public override void PostUpdate()
        {
            float num2 = 3E-05f * (float)Main.worldRate;
            //float num3 = 1.5E-05f * (float)Main.worldRate;
            int num4 = 0;
            while ((float)num4 < (float)(Main.maxTilesX * Main.maxTilesY) * num2)
            {
                int num5 = WorldGen.genRand.Next(10, Main.maxTilesX - 10);
                int num6 = WorldGen.genRand.Next(10, /*(int)Main.worldSurface - 1*/ Main.maxTilesY - 20);
                int num7 = num5 - 1;
                int num8 = num5 + 2;
                int num9 = num6 - 1;
                int num10 = num6 + 2;
                if (num7 < 10)
                {
                    num7 = 10;
                }
                if (num8 > Main.maxTilesX - 10)
                {
                    num8 = Main.maxTilesX - 10;
                }
                if (num9 < 10)
                {
                    num9 = 10;
                }
                if (num10 > Main.maxTilesY - 10)
                {
                    num10 = Main.maxTilesY - 10;
                }
                if (Main.tile[num5, num6] != null)
                {
                    if (Main.tile[num5, num6].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage1>() || Main.tile[num5, num6].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage2>() ||
                        Main.tile[num5, num6].type == (ushort)ModContent.TileType<Tiles.LargeHerbsStage3>())
                    {
                        GrowLargeHerb(num5, num6);
                    }
                    #region hardmode/superhardmode stuff
                    if (Main.tile[num5, num6].nactive())
                    {
                        ContagionHardmodeSpread(num5, num6);
                        if (Main.hardMode) SpreadXanthophyte(num5, num6);
                        if (ExxoAvalonOrigins.superHardmode && WorldDarkMatterTiles < 250000)
                        {
                            DarkMatterSpread(num5, num6);
                        }
                    }
                    #endregion
                    #region tropical short grass
                    if (Main.tile[num5, num6].type == ModContent.TileType<TropicalGrass>())
                    {
                        int num14 = (int)Main.tile[num5, num6].type;
                        if (!Main.tile[num5, num9].active() && !Main.tile[num5, num6].halfBrick() && Main.tile[num5, num6].slope() == 0 && WorldGen.genRand.Next(5) == 0 && num14 == ModContent.TileType<TropicalGrass>())
                        {
                            WorldGen.PlaceTile(num5, num9, ModContent.TileType<TropicalShortGrass>(), true, false, -1, 0);
                            Main.tile[num5, num9].frameX = (short)(WorldGen.genRand.Next(0, 8) * 18);
                            if (num9 > Main.worldSurface && WorldGen.genRand.Next(60) == 0)
                            {
                                Main.tile[num5, num9].frameX = 8 * 18;
                                Main.tileLighted[Main.tile[num5, num9].type] = true;
                            }
                            if (Main.tile[num5, num9].active())
                            {
                                Main.tile[num5, num9].color(Main.tile[num5, num6].color());
                            }
                            if (Main.netMode == NetmodeID.Server && Main.tile[num5, num9].active())
                            {
                                NetMessage.SendTileSquare(-1, num5, num9, 1);
                            }
                        }
                        if (!Main.tile[num5, num9].nactive())
                        {
                            return;
                        }
                        /*if (Main.tile[num5, num9].type == ModContent.TileType<TropicalShortGrass>() && WorldGen.genRand.Next(3) == 0 && Main.tile[num5, num9].frameX < 144)
                        {
                            if (Main.rand.Next(4) == 0)
                            {
                                Main.tile[num5, num9].frameX = (short)(162 + WorldGen.genRand.Next(8) * 18);
                            }
                            Main.tile[num5, num9].type = 74;
                            if (Main.netMode == NetmodeID.Server)
                            {
                                NetMessage.SendTileSquare(-1, num5, num9, 1);
                            }
                        }*/
                    }
                    #endregion
                    #region sweetstem spawning
                    if (Main.tile[num5, num6].type == ModContent.TileType<Nest>() || Main.tile[num5, num6].type == TileID.Hive)
                    {
                        int num14 = (int)Main.tile[num5, num6].type;
                        if (!Main.tile[num5, num9].active() && !Main.tile[num5, num6].halfBrick() && Main.tile[num5, num6].slope() == 0 && WorldGen.genRand.Next(30) == 0 && (num14 == ModContent.TileType<Nest>() || num14 == TileID.Hive))
                        {
                            WorldGen.PlaceTile(num5, num9, ModContent.TileType<Tiles.Herbs.Sweetstem>(), true, false, -1, 0);
                            if (Main.tile[num5, num9].active())
                            {
                                Main.tile[num5, num9].color(Main.tile[num5, num6].color());
                            }
                            if (Main.netMode == NetmodeID.Server && Main.tile[num5, num9].active())
                            {
                                NetMessage.SendTileSquare(-1, num5, num9, 1);
                            }
                        }
                    }
                    #endregion
                    #region contagion shortgrass/barfbush spawning
                    if (Main.tile[num5, num6].type == ModContent.TileType<Ickgrass>())
                    {
                        int num14 = (int)Main.tile[num5, num6].type;
                        if (!Main.tile[num5, num9].active() && !Main.tile[num5, num6].halfBrick() && Main.tile[num5, num6].slope() == 0 && WorldGen.genRand.Next(5) == 0 && num14 == ModContent.TileType<Ickgrass>())
                        {
                            WorldGen.PlaceTile(num5, num9, ModContent.TileType<ContagionShortGrass>(), true, false, -1, 0);
                            Main.tile[num5, num9].frameX = (short)(WorldGen.genRand.Next(0, 11) * 18);
                            if (Main.tile[num5, num9].active())
                            {
                                Main.tile[num5, num9].color(Main.tile[num5, num6].color());
                            }
                            if (Main.netMode == NetmodeID.Server && Main.tile[num5, num9].active())
                            {
                                NetMessage.SendTileSquare(-1, num5, num9, 1);
                            }
                        }
                        if (!Main.tile[num5, num9].active() && !Main.tile[num5, num6].halfBrick() && Main.tile[num5, num6].slope() == 0 && WorldGen.genRand.Next(20) == 0 && num14 == ModContent.TileType<Ickgrass>())
                        {
                            WorldGen.PlaceTile(num5, num9, ModContent.TileType<Tiles.Herbs.Barfbush>(), true, false, -1, 0);
                            if (Main.tile[num5, num9].active())
                            {
                                Main.tile[num5, num9].color(Main.tile[num5, num6].color());
                            }
                            if (Main.netMode == NetmodeID.Server && Main.tile[num5, num9].active())
                            {
                                NetMessage.SendTileSquare(-1, num5, num9, 1);
                            }
                        }
                        bool flag2 = false;
                        for (int m = num7; m < num8; m++)
                        {
                            for (int n = num9; n < num10; n++)
                            {
                                if ((num5 != m || num6 != n) && Main.tile[m, n].active())
                                {
                                    if (Main.tile[m, n].type == 0 || (num14 == ModContent.TileType<Ickgrass>() && Main.tile[m, n].type == TileID.Grass))
                                    {
                                        WorldGen.SpreadGrass(m, n, 0, num14, false, Main.tile[num5, num6].color());
                                        if (num14 == ModContent.TileType<Ickgrass>())
                                        {
                                            WorldGen.SpreadGrass(m, n, TileID.Grass, num14, false, Main.tile[num5, num6].color());
                                        }
                                        if (num14 == ModContent.TileType<Ickgrass>())
                                        {
                                            WorldGen.SpreadGrass(m, n, TileID.HallowedGrass, num14, false, Main.tile[num5, num6].color());
                                        }
                                        if ((int)Main.tile[m, n].type == num14)
                                        {
                                            WorldGen.SquareTileFrame(m, n, true);
                                            flag2 = true;
                                        }
                                    }
                                    if (Main.tile[m, n].type == 0 || (num14 == 109 && Main.tile[m, n].type == 2) || (num14 == 109 && Main.tile[m, n].type == 23) || (num14 == 109 && Main.tile[m, n].type == 199))
                                    {
                                        if (num14 == TileID.HallowedGrass)
                                        {
                                            WorldGen.SpreadGrass(m, n, ModContent.TileType<Ickgrass>(), num14, false, Main.tile[num5, num6].color());
                                        }
                                    }
                                    if (Main.tile[m, n].type == (ushort)ModContent.TileType<TropicalMud>())
                                    {
                                        WorldGen.SpreadGrass(m, n, ModContent.TileType<TropicalMud>(), ModContent.TileType<TropicalGrass>(), false, Main.tile[num5, num6].color());
                                    }
                                    if (Main.tile[m, n].type == TileID.Ash)
                                    {
                                        WorldGen.SpreadGrass(m, n, TileID.Ash, ModContent.TileType<Impgrass>(), false, Main.tile[num5, num6].color());
                                    }
                                }
                            }
                        }
                        if (Main.netMode == NetmodeID.Server && flag2)
                        {
                            NetMessage.SendTileSquare(-1, num5, num6, 3);
                        }
                    }
                    #endregion
                    #region impvines growing
                    if ((Main.tile[num5, num6].type == ModContent.TileType<Impgrass>() || Main.tile[num5, num6].type == ModContent.TileType<Impvines>()) && WorldGen.genRand.Next(15) == 0 && !Main.tile[num5, num6 + 1].active() && !Main.tile[num5, num6 + 1].lava())
                    {
                        bool flag10 = false;
                        for (int num47 = num6; num47 > num6 - 10; num47--)
                        {
                            if (Main.tile[num5, num47].bottomSlope())
                            {
                                flag10 = false;
                                break;
                            }
                            if (Main.tile[num5, num47].active() && Main.tile[num5, num47].type == ModContent.TileType<Impgrass>() && !Main.tile[num5, num47].bottomSlope())
                            {
                                flag10 = true;
                                break;
                            }
                        }
                        if (flag10)
                        {
                            int num48 = num5;
                            int num49 = num6 + 1;
                            Main.tile[num48, num49].type = (ushort)ModContent.TileType<Impvines>();
                            Main.tile[num48, num49].active(true);
                            WorldGen.SquareTileFrame(num48, num49, true);
                            if (Main.netMode == NetmodeID.Server)
                            {
                                NetMessage.SendTileSquare(-1, num48, num49, 3);
                            }
                        }
                    }
                    #endregion
                    #region contagion vines growing
                    if ((Main.tile[num5, num6].type == ModContent.TileType<Ickgrass>() || Main.tile[num5, num6].type == ModContent.TileType<ContagionVines>()) && WorldGen.genRand.Next(15) == 0 && !Main.tile[num5, num6 + 1].active() && !Main.tile[num5, num6 + 1].lava())
                    {
                        bool flag10 = false;
                        for (int num47 = num6; num47 > num6 - 10; num47--)
                        {
                            if (Main.tile[num5, num47].bottomSlope())
                            {
                                flag10 = false;
                                break;
                            }
                            if (Main.tile[num5, num47].active() && Main.tile[num5, num47].type == ModContent.TileType<Ickgrass>() && !Main.tile[num5, num47].bottomSlope())
                            {
                                flag10 = true;
                                break;
                            }
                        }
                        if (flag10)
                        {
                            int num48 = num5;
                            int num49 = num6 + 1;
                            Main.tile[num48, num49].type = (ushort)ModContent.TileType<ContagionVines>();
                            Main.tile[num48, num49].active(true);
                            WorldGen.SquareTileFrame(num48, num49, true);
                            if (Main.netMode == NetmodeID.Server)
                            {
                                NetMessage.SendTileSquare(-1, num48, num49, 3);
                            }
                        }
                    }
                    #endregion
                }
                num4++;
            }
            if (!Main.dayTime && Main.player[Main.myPlayer].HasBuff(ModContent.BuffType<Buffs.AdvancedBuffs.AdvStarbright>()) || Main.player[Main.myPlayer].HasBuff(ModContent.BuffType<Buffs.Starbright>()))
            {
                float num66 = (float)(Main.maxTilesX / 4200);
                if ((float)Main.rand.Next(4000) < 10f * num66)
                {
                    int num67 = 12;
                    int num68 = Main.rand.Next(Main.maxTilesX - 50) + 100;
                    num68 *= 16;
                    int num69 = Main.rand.Next((int)((double)Main.maxTilesY * 0.05));
                    num69 *= 16;
                    Vector2 vector = new Vector2((float)num68, (float)num69);
                    float num70 = (float)Main.rand.Next(-100, 101);
                    float num71 = (float)(Main.rand.Next(200) + 100);
                    float num72 = (float)Math.Sqrt((double)(num70 * num70 + num71 * num71));
                    num72 = (float)num67 / num72;
                    num70 *= num72;
                    num71 *= num72;
                    Projectile.NewProjectile(vector.X, vector.Y, num70, num71, ProjectileID.FallingStar, 1000, 10f, Main.myPlayer);
                }
            }
            if (!Main.dayTime && Main.player[Main.myPlayer].HasBuff(ModContent.BuffType<Buffs.AdvancedBuffs.AdvStarbright>()))
            {
                float num66 = (float)(Main.maxTilesX / 4200);
                if ((float)Main.rand.Next(4000) < 10f * num66)
                {
                    int num67 = 12;
                    int num68 = Main.rand.Next(Main.maxTilesX - 50) + 100;
                    num68 *= 16;
                    int num69 = Main.rand.Next((int)((double)Main.maxTilesY * 0.05));
                    num69 *= 16;
                    Vector2 vector = new Vector2((float)num68, (float)num69);
                    float num70 = (float)Main.rand.Next(-100, 101);
                    float num71 = (float)(Main.rand.Next(200) + 100);
                    float num72 = (float)Math.Sqrt((double)(num70 * num70 + num71 * num71));
                    num72 = (float)num67 / num72;
                    num70 *= num72;
                    num71 *= num72;
                    Projectile.NewProjectile(vector.X, vector.Y, num70, num71, ProjectileID.FallingStar, 1000, 10f, Main.myPlayer);
                }
            }
            if (!Main.dayTime && Main.bloodMoon)
            {
                float num66 = (float)(Main.maxTilesX / 4200);
                if ((float)Main.rand.Next(9000) < 10f * num66)
                {
                    int num67 = 12;
                    int num68 = Main.rand.Next(Main.maxTilesX - 50) + 100;
                    num68 *= 16;
                    int num69 = Main.rand.Next((int)((double)Main.maxTilesY * 0.05));
                    num69 *= 16;
                    Vector2 vector = new Vector2((float)num68, (float)num69);
                    float num70 = (float)Main.rand.Next(-100, 101);
                    float num71 = (float)(Main.rand.Next(200) + 100);
                    float num72 = (float)Math.Sqrt((double)(num70 * num70 + num71 * num71));
                    num72 = (float)num67 / num72;
                    num70 *= num72;
                    num71 *= num72;
                    Projectile.NewProjectile(vector.X, vector.Y, num70, num71, ProjectileID.FallingStar, 1000, 10f, Main.myPlayer);
                }
            }
            for (int thing = 0; thing < Main.npc.Length; thing++)
            {
                NPC npc1 = Main.npc[thing];
                if ((npc1.type == NPCID.Corruptor || npc1.type == ModContent.NPCType<NPCs.GuardianCorruptor>()) && npc1.active)
                {
                    for (int thing2 = 0; thing2 < Main.npc.Length; thing2++)
                    {
                        NPC npc2 = Main.npc[thing2];
                        if ((npc2.type == ModContent.NPCType<NPCs.Hallowor>() || npc2.type == ModContent.NPCType<NPCs.AegisHallowor>()) && npc2.active)
                        {
                            int radius;
                            string text;
                            if (npc1.type == NPCID.Corruptor && npc2.type == ModContent.NPCType<NPCs.Hallowor>())
                            {
                                radius = 2;
                                text = "Dark and light have been obliterated...";
                                MakeOblivionOre(npc1, npc2, text, radius);
                            }
                            else if (npc1.type == ModContent.NPCType<NPCs.GuardianCorruptor>() && npc2.type == ModContent.NPCType<NPCs.AegisHallowor>())
                            {
                                radius = 3;
                                text = "Dark and light have been eliminated...";
                                MakeOblivionOre(npc1, npc2, text, radius);
                            }
                        }
                    }
                }
            }
        }
        public override void PreUpdate()
        {
            if (!retroGenned)
            {
                if (ExxoAvalonOrigins.lastOpenedVersion == null || ExxoAvalonOrigins.lastOpenedVersion < ExxoAvalonOrigins.version)
                {
                    RetroGen();
                    retroGenned = true;
                }
            }
            if (Main.time == 16200.0 && Main.rand.Next(4) == 0 && NPC.downedGolemBoss && ExxoAvalonOriginsGlobalNPC.stoppedArmageddon && ExxoAvalonOrigins.superHardmode && Main.hardMode)
            {
                DropComet(ModContent.TileType<Tiles.HydrolythOre>());
            }
        }
        public override void PreWorldGen()
        {
            ExxoAvalonOrigins.superHardmode = false;
            ExxoAvalonOriginsGlobalNPC.stoppedArmageddon = false;
            ExxoAvalonOriginsGlobalNPC.oblivionDead = false;
            ExxoAvalonOriginsGlobalNPC.oblivionTimes = 0;
            downedBacteriumPrime = false;
            downedDesertBeak = false;
            downedDragonLord = false;
            downedMechasting = false;
            downedOblivion = false;
            downedPhantasm = false;
            downedKingSting = false;
            hiddenTemplePos = Vector2.Zero;

            if (jungleMenuSelection == JungleVariant.random)
            {
                jungleMenuSelection = (JungleVariant)WorldGen.genRand.Next(2);
            }

            contaigon = false;
            WorldGen.crimson = WorldGen.genRand.Next(2) == 0;
            if (WorldGen.WorldGenParam_Evil == 0)
            {
                WorldGen.crimson = false;
            }
            if (WorldGen.WorldGenParam_Evil == 1)
            {
                WorldGen.crimson = true;
            }
            if (WorldGen.WorldGenParam_Evil == -1)
            {
                contaigon = WorldGen.genRand.Next(3) == 0;
                if (contaigon)
                    WorldGen.crimson = false;
            }
            if (WorldGen.WorldGenParam_Evil == 2)
            {
                contaigon = true;
                WorldGen.crimson = false;
            }
        }

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            var reset = tasks.FindIndex(genpass => genpass.Name == "Reset");
            if (reset != -1)
            {
                tasks.Insert(reset + 1, new PassLegacy("Avalon Setup", World.Passes.Setup.Method));
            }

            var vines = tasks.FindIndex(genpass => genpass.Name == "Vines");

            if (jungleMenuSelection == JungleVariant.tropics)
            {
                var temple = tasks.FindIndex(genpass => genpass.Name == "Jungle Temple");
                if (temple != -1)
                {
                    tasks[temple] = new PassLegacy("Tuhrtl Outpost", World.Passes.TuhrtlOutpost.Method);
                    //tasks.RemoveAt(temple);
                }

                var hives = tasks.FindIndex(genpass => genpass.Name == "Hives");
                if (hives != -1)
                {
                    tasks[hives] = new PassLegacy("Wasp Nests", World.Passes.WaspNest.Method);
                    //tasks.RemoveAt(hives);
                }

                var jchests = tasks.FindIndex(genpass => genpass.Name == "Jungle Chests");
                if (jchests != -1)
                {
                    tasks[jchests] = new PassLegacy("Sanctums", World.Passes.TropicsSanctum.Method);
                    //tasks.RemoveAt(jchests);
                }

                var jtemple2 = tasks.FindIndex(genpass => genpass.Name == "Temple");
                if (jtemple2 != -1)
                {
                    tasks.RemoveAt(jtemple2);
                }

                var jplants = tasks.FindIndex(genpass => genpass.Name == "Jungle Plants");
                if (jplants != -1)
                {
                    tasks.RemoveAt(jplants);
                }

                if (vines != -1)
                {
                    tasks.Insert(vines + 1, new PassLegacy("TropicalVines", World.Passes.TropicalVines.Method));
                }
            }

            if (vines != -1)
            {
                tasks.Insert(vines + 1, new PassLegacy("Impvines", World.Passes.Impvines.Method));
            }

            if (vines != -1)
            {
                if (contaigon)
                    tasks.Insert(vines + 1, new PassLegacy("ContagionVines", World.Passes.ContagionVines.Method));
            }

            var shinies = tasks.FindIndex(genpass => genpass.Name == "Shinies");
            if (shinies != -1)
            {
                tasks[shinies] = new PassLegacy("Avalon PHM Ore Gen", World.Passes.OreGenPreHardMode.Method);
            }

            var underworld = tasks.FindIndex(genpass => genpass.Name == "Underworld");
            if (underworld != -1)
            {
                tasks.Insert(underworld + 1, new PassLegacy("Avalon Underworld", World.Passes.Underworld.Method));
            }

            if (contaigon)
            {
                var corruptionTask = tasks.FindIndex(genpass => genpass.Name == "Corruption");
                if (corruptionTask != -1)
                {
                    // Replace corruption task with contagion task
                    tasks[corruptionTask] = new PassLegacy("Corruption", World.Passes.Contagion.Method);
                }

                var altarsTask = tasks.FindIndex(genpass => genpass.Name == "Altars");
                if (altarsTask != -1)
                {
                    tasks[altarsTask] = new PassLegacy("Altars", World.Passes.Altars.Method);
                }
            }

            var gems = tasks.FindIndex(genpass => genpass.Name == "Gems");
            if (gems != -1)
            {
                tasks.Insert(gems + 1, new PassLegacy("Avalon Gems", World.Passes.Gems.Method));
            }

            var smoothWorld = tasks.FindIndex(genpass => genpass.Name == "Smooth World");
            if (smoothWorld != -1)
            {
                tasks.Insert(smoothWorld + 1, new PassLegacy("Unsmoothing Hellcastle", World.Passes.SmoothWorld.Method));
            }

            var lifecrystals = tasks.FindIndex(genpass => genpass.Name == "Life Crystals");
            if (lifecrystals != -1)
            {
                tasks.Insert(lifecrystals + 1, new PassLegacy("Adding Mana Crystals", World.Passes.ManaCrystal.Method));
            }

            var iceWalls = tasks.FindIndex(genpass => genpass.Name == "Ice Walls");
            if (iceWalls != -1)
            {
                tasks.Insert(iceWalls + 1, new PassLegacy("Avalon Shrines", World.Passes.Shrines.Method));
            }

            var weeds = tasks.FindIndex(genpass => genpass.Name == "Weeds");
            if (weeds != -1)
            {
                tasks.Insert(weeds + 1, new PassLegacy("Contagion weeds", World.Passes.Plants.Method));
            }

            var microBiomes = tasks.FindIndex(genpass => genpass.Name == "Micro Biomes");
            if (microBiomes != -1)
            {
                tasks.RemoveAt(microBiomes);
                //tasks.Insert(microBiomes, new PassLegacy("Avalon Contaigon fix 1", delegate (GenerationProgress progress)
                //{
                //    if (contaigon) WorldGen.crimson = true;
                //}));
                tasks.Insert(microBiomes + 1, new PassLegacy("Avalon Micro Biomes Fix", World.Passes.MicroBiomes.Method));
                tasks.Insert(microBiomes + 1, new PassLegacy("Replacing items in chests", World.Passes.ReplaceChestItems.Method));

                //tasks.Insert(microBiomes + 1, new PassLegacy("Nest Test", World.Passes.TuhrtlOutpost.Method));
                //tasks.Insert(microBiomes + 1, new PassLegacy("Nest", World.Passes.WaspNest.Method));
            }
        }
        public void SpreadXanthophyte(int x, int y)
        {
            if (Main.tile[x, y].inActive())
                return;

            int type = Main.tile[x, y].type;

            if ((double)y > (Main.worldSurface + Main.rockLayer) / 2.0)
            {
                if ((type == ModContent.TileType<Tiles.TropicalGrass>()/* || type == ModContent.TileType<Tiles.BrownIce>()*/) && WorldGen.genRand.Next(325) == 0)
                {
                    int num6 = x + WorldGen.genRand.Next(-10, 11);
                    int num7 = y + WorldGen.genRand.Next(-10, 11);
                    if (Main.tile[num6, num7].active() && (Main.tile[num6, num7].type == ModContent.TileType<Tiles.TropicalMud>()/* || Main.tile[num6, num7].type == ModContent.TileType<Tiles.BrownIce>()*/) && (!Main.tile[num6, num7 - 1].active() || (Main.tile[num6, num7 - 1].type != 5 && Main.tile[num6, num7 - 1].type != 236 && Main.tile[num6, num7 - 1].type != 238)) && GrowingOreSpread.GrowingOre(x, y, ModContent.TileType<Tiles.Ores.XanthophyteOre>()))
                    {
                        Main.tile[num6, num7].type = (ushort)ModContent.TileType<Tiles.Ores.XanthophyteOre>();
                        WorldGen.SquareTileFrame(num6, num7, true);
                    }
                }
                if (type == (ushort)ModContent.TileType<Tiles.Ores.XanthophyteOre>() && WorldGen.genRand.Next(3) != 0)
                {
                    int num8 = x;
                    int num9 = y;
                    int num10 = WorldGen.genRand.Next(4);
                    if (num10 == 0)
                    {
                        num8++;
                    }
                    if (num10 == 1)
                    {
                        num8--;
                    }
                    if (num10 == 2)
                    {
                        num9++;
                    }
                    if (num10 == 3)
                    {
                        num9--;
                    }
                    if (Main.tile[num8, num9].active() && (Main.tile[num8, num9].type == ModContent.TileType<TropicalMud>() || Main.tile[num8, num9].type == ModContent.TileType<TropicalGrass>()) /*|| Main.tile[num8, num9].type == ModContent.TileType<Tiles.BrownIce>())*/ && GrowingOreSpread.GrowingOre(x, y, ModContent.TileType<Tiles.Ores.XanthophyteOre>()))
                    {
                        Main.tile[num8, num9].type = (ushort)ModContent.TileType<Tiles.Ores.XanthophyteOre>();
                        WorldGen.SquareTileFrame(num8, num9, true);
                    }
                }

                /*if ((type == 70) && WorldGen.genRand.Next(150) == 0)
                {
                    int num6 = x + WorldGen.genRand.Next(-10, 11);
                    int num7 = y + WorldGen.genRand.Next(-10, 11);
                    if (Main.tile[num6, num7].active() && (Main.tile[num6, num7].type == 59 || Main.tile[num6, num7].type == 70) && (!Main.tile[num6, num7 - 1].active() || (Main.tile[num6, num7 - 1].type != 5 && Main.tile[num6, num7 - 1].type != 236 && Main.tile[num6, num7 - 1].type != 238)) && WorldGen.Shroomite(num6, num7))
                    {
                        Main.tile[num6, num7].type = 406;
                        WorldGen.SquareTileFrame(num6, num7, true);
                    }
                }
                if (type == 406 && WorldGen.genRand.Next(3) != 0)
                {
                    int num8 = i;
                    int num9 = j;
                    int num10 = WorldGen.genRand.Next(4);
                    if (num10 == 0)
                    {
                        num8++;
                    }
                    if (num10 == 1)
                    {
                        num8--;
                    }
                    if (num10 == 2)
                    {
                        num9++;
                    }
                    if (num10 == 3)
                    {
                        num9--;
                    }
                    if (Main.tile[num8, num9].active() && (Main.tile[num8, num9].type == 59 || Main.tile[num8, num9].type == 70) && WorldGen.Shroomite(num8, num9))
                    {
                        Main.tile[num8, num9].type = 406;
                        WorldGen.SquareTileFrame(num8, num9, true);
                    }
                }

                if ((type == 161 || type == 163 || type == 164 || type == 200 || type == 361) && WorldGen.genRand.Next(150) == 0)
                {
                    int num6 = i + WorldGen.genRand.Next(-10, 11);
                    int num7 = j + WorldGen.genRand.Next(-10, 11);
                    if (Main.tile[num6, num7].active() && (Main.tile[num6, num7].type == 161 || Main.tile[num6, num7].type == 163 || Main.tile[num6, num7].type == 164 || Main.tile[num6, num7].type == 200 || Main.tile[num6, num7].type == 361) && (!Main.tile[num6, num7 - 1].active() || (Main.tile[num6, num7 - 1].type != 5 && Main.tile[num6, num7 - 1].type != 236 && Main.tile[num6, num7 - 1].type != 238)) && WorldGen.Ferozium(num6, num7))
                    {
                        Main.tile[num6, num7].type = 379;
                        WorldGen.SquareTileFrame(num6, num7, true);
                    }
                }
                if (type == 379 && WorldGen.genRand.Next(3) != 0)
                {
                    int num8 = i;
                    int num9 = j;
                    int num10 = WorldGen.genRand.Next(4);
                    if (num10 == 0)
                    {
                        num8++;
                    }
                    if (num10 == 1)
                    {
                        num8--;
                    }
                    if (num10 == 2)
                    {
                        num9++;
                    }
                    if (num10 == 3)
                    {
                        num9--;
                    }
                    if (Main.tile[num8, num9].active() && (Main.tile[num8, num9].type == 161 || Main.tile[num8, num9].type == 164 || Main.tile[num8, num9].type == 361 || Main.tile[num8, num9].type == 163 || Main.tile[num8, num9].type == 200 || Main.tile[num8, num9].type == 411) && WorldGen.Ferozium(num8, num9))
                    {
                        Main.tile[num8, num9].type = 379;
                        WorldGen.SquareTileFrame(num8, num9, true);
                    }
                }*/
            }
        }
        public static bool GrowHellTree(int i, int y)
        {
            int j;
            for (j = y; TileLoader.IsSapling(Main.tile[i, j].type); j--)
            {
            }
            if ((Main.tile[i - 1, j - 1].liquid != 0 || Main.tile[i, j - 1].liquid != 0 || Main.tile[i + 1, j - 1].liquid != 0) && Main.tile[i, j].type != 60)
            {
                return false;
            }
            if (Main.tile[i, j].nactive() && !Main.tile[i, j].halfBrick() && Main.tile[i, j].slope() == 0 && TileLoader.CanGrowModTree(Main.tile[i - 1, j].type) || TileLoader.CanGrowModTree(Main.tile[i + 1, j].type) || TileLoader.CanGrowModTree(Main.tile[i, j].type))
            {
                int num = 2;
                int maxTreeHeight = 16;
                if (WorldGen.EmptyTileCheck(i - num, i + num, j + maxTreeHeight, j + 1, TileID.Saplings))
                {
                    bool flag = false;
                    bool flag2 = false;
                    int heightOfTree = WorldGen.genRand.Next(5, maxTreeHeight + 1);
                    int num4;
                    for (int k = j + heightOfTree; k > j; k--)
                    {
                        Main.tile[i, k].frameNumber((byte)WorldGen.genRand.Next(3));
                        Main.tile[i, k].active(active: true);
                        Main.tile[i, k].type = 5;
                        num4 = WorldGen.genRand.Next(3);
                        int num5 = WorldGen.genRand.Next(10);
                        if (k == j + 1 || k == j + heightOfTree)
                        {
                            num5 = 0;
                        }
                        while (((num5 == 5 || num5 == 7) && flag) || ((num5 == 6 || num5 == 7) && flag2))
                        {
                            num5 = WorldGen.genRand.Next(10);
                        }
                        flag = false;
                        flag2 = false;
                        if (num5 == 5 || num5 == 7)
                        {
                            flag = true;
                        }
                        if (num5 == 6 || num5 == 7)
                        {
                            flag2 = true;
                        }
                        switch (num5)
                        {
                            case 1:
                                if (num4 == 0)
                                {
                                    Main.tile[i, k].frameX = 0;
                                    Main.tile[i, k].frameY = 176; // changed - 66
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 0;
                                    Main.tile[i, k].frameY = 154; // changed - 88
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 0;
                                    Main.tile[i, k].frameY = 132; // changed - 110
                                }
                                break;
                            case 2:
                                if (num4 == 0)
                                {
                                    Main.tile[i, k].frameX = 22;
                                    Main.tile[i, k].frameY = 242; // changed - 0
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 22;
                                    Main.tile[i, k].frameY = 220; // changed - 22
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 22;
                                    Main.tile[i, k].frameY = 198; // changed - 44
                                }
                                break;
                            case 3:
                                if (num4 == 0)
                                {
                                    Main.tile[i, k].frameX = 44;
                                    Main.tile[i, k].frameY = 176; // changed - 66
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 44;
                                    Main.tile[i, k].frameY = 154; // changed - 88
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 44;
                                    Main.tile[i, k].frameY = 132; // changed - 110
                                }
                                break;
                            case 4:
                                if (num4 == 0) // changed - 66 88 110
                                {
                                    Main.tile[i, k].frameX = 22;
                                    Main.tile[i, k].frameY = 176;
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 22;
                                    Main.tile[i, k].frameY = 154;
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 22;
                                    Main.tile[i, k].frameY = 132;
                                }
                                break;
                            case 5:
                                if (num4 == 0) // changed - 0 22 44
                                {
                                    Main.tile[i, k].frameX = 88;
                                    Main.tile[i, k].frameY = 242;
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 88;
                                    Main.tile[i, k].frameY = 220;
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 88;
                                    Main.tile[i, k].frameY = 198;
                                }
                                break;
                            case 6:
                                if (num4 == 0) // changed - 66 88 110
                                {
                                    Main.tile[i, k].frameX = 66;
                                    Main.tile[i, k].frameY = 176;
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 66;
                                    Main.tile[i, k].frameY = 154;
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 66;
                                    Main.tile[i, k].frameY = 132;
                                }
                                break;
                            case 7:
                                if (num4 == 0) // 66 88 110
                                {
                                    Main.tile[i, k].frameX = 110;
                                    Main.tile[i, k].frameY = 176;
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 110;
                                    Main.tile[i, k].frameY = 154;
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 110;
                                    Main.tile[i, k].frameY = 132;
                                }
                                break;
                            default:
                                if (num4 == 0) // 0 22 44
                                {
                                    Main.tile[i, k].frameX = 0;
                                    Main.tile[i, k].frameY = 242;
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i, k].frameX = 0;
                                    Main.tile[i, k].frameY = 220;
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i, k].frameX = 0;
                                    Main.tile[i, k].frameY = 198;
                                }
                                break;
                        }
                        if (num5 == 5 || num5 == 7)
                        {
                            Main.tile[i - 1, k].active(active: true);
                            Main.tile[i - 1, k].type = 5;
                            num4 = WorldGen.genRand.Next(3);
                            if (WorldGen.genRand.Next(3) < 2)
                            {
                                if (num4 == 0) // 198 220 242
                                {
                                    Main.tile[i - 1, k].frameX = 44;
                                    Main.tile[i - 1, k].frameY = 44;
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i - 1, k].frameX = 44;
                                    Main.tile[i - 1, k].frameY = 22;
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i - 1, k].frameX = 44;
                                    Main.tile[i - 1, k].frameY = 0;
                                }
                            }
                            else
                            {
                                if (num4 == 0) // 0 22 44
                                {
                                    Main.tile[i - 1, k].frameX = 66;
                                    Main.tile[i - 1, k].frameY = 242;
                                }
                                if (num4 == 1)
                                {
                                    Main.tile[i - 1, k].frameX = 66;
                                    Main.tile[i - 1, k].frameY = 220;
                                }
                                if (num4 == 2)
                                {
                                    Main.tile[i - 1, k].frameX = 66;
                                    Main.tile[i - 1, k].frameY = 198;
                                }
                            }
                        }
                        if (num5 != 6 && num5 != 7)
                        {
                            continue;
                        }
                        Main.tile[i + 1, k].active(active: true);
                        Main.tile[i + 1, k].type = 5;
                        num4 = WorldGen.genRand.Next(3);
                        if (WorldGen.genRand.Next(3) < 2)
                        {
                            if (num4 == 0) // 198 220 242
                            {
                                Main.tile[i + 1, k].frameX = 66;
                                Main.tile[i + 1, k].frameY = 44;
                            }
                            if (num4 == 1)
                            {
                                Main.tile[i + 1, k].frameX = 66;
                                Main.tile[i + 1, k].frameY = 22;
                            }
                            if (num4 == 2)
                            {
                                Main.tile[i + 1, k].frameX = 66;
                                Main.tile[i + 1, k].frameY = 0;
                            }
                        }
                        else
                        {
                            if (num4 == 0) // 66 88 110
                            {
                                Main.tile[i + 1, k].frameX = 88;
                                Main.tile[i + 1, k].frameY = 176;
                            }
                            if (num4 == 1)
                            {
                                Main.tile[i + 1, k].frameX = 88;
                                Main.tile[i + 1, k].frameY = 154;
                            }
                            if (num4 == 2)
                            {
                                Main.tile[i + 1, k].frameX = 88;
                                Main.tile[i + 1, k].frameY = 132;
                            }
                        }
                    }
                    int num6 = WorldGen.genRand.Next(3);
                    bool flag3 = false;
                    bool flag4 = false;
                    if (Main.tile[i - 1, j].nactive() && !Main.tile[i - 1, j].halfBrick() && Main.tile[i - 1, j].slope() == 0 && (Main.tile[i - 1, j].type == 2 || Main.tile[i - 1, j].type == 23 || Main.tile[i - 1, j].type == 60 || Main.tile[i - 1, j].type == 109 || Main.tile[i - 1, j].type == 147 || Main.tile[i - 1, j].type == 199 || TileLoader.CanGrowModTree(Main.tile[i - 1, j].type)))
                    {
                        flag3 = true;
                    }
                    if (Main.tile[i + 1, j].nactive() && !Main.tile[i + 1, j].halfBrick() && Main.tile[i + 1, j].slope() == 0 && (Main.tile[i + 1, j].type == 2 || Main.tile[i + 1, j].type == 23 || Main.tile[i + 1, j].type == 60 || Main.tile[i + 1, j].type == 109 || Main.tile[i + 1, j].type == 147 || Main.tile[i + 1, j].type == 199 || TileLoader.CanGrowModTree(Main.tile[i + 1, j].type)))
                    {
                        flag4 = true;
                    }
                    if (!flag3)
                    {
                        if (num6 == 0)
                        {
                            num6 = 2;
                        }
                        if (num6 == 1)
                        {
                            num6 = 3;
                        }
                    }
                    if (!flag4)
                    {
                        if (num6 == 0)
                        {
                            num6 = 1;
                        }
                        if (num6 == 2)
                        {
                            num6 = 3;
                        }
                    }
                    if (flag3 && !flag4)
                    {
                        num6 = 2;
                    }
                    if (flag4 && !flag3)
                    {
                        num6 = 1;
                    }
                    if (num6 == 0 || num6 == 1)
                    {
                        Main.tile[i + 1, j - 1].active(active: true);
                        Main.tile[i + 1, j - 1].type = 5;
                        num4 = WorldGen.genRand.Next(3);
                        if (num4 == 0) // 132 154 176
                        {
                            Main.tile[i + 1, j - 1].frameX = 22;
                            Main.tile[i + 1, j - 1].frameY = 110;
                        }
                        if (num4 == 1)
                        {
                            Main.tile[i + 1, j - 1].frameX = 22;
                            Main.tile[i + 1, j - 1].frameY = 88;
                        }
                        if (num4 == 2)
                        {
                            Main.tile[i + 1, j - 1].frameX = 22;
                            Main.tile[i + 1, j - 1].frameY = 66;
                        }
                    }
                    if (num6 == 0 || num6 == 2)
                    {
                        Main.tile[i - 1, j - 1].active(active: true);
                        Main.tile[i - 1, j - 1].type = 5;
                        num4 = WorldGen.genRand.Next(3);
                        if (num4 == 0) // 132 154 176
                        {
                            Main.tile[i - 1, j - 1].frameX = 44;
                            Main.tile[i - 1, j - 1].frameY = 110;
                        }
                        if (num4 == 1)
                        {
                            Main.tile[i - 1, j - 1].frameX = 44;
                            Main.tile[i - 1, j - 1].frameY = 88;
                        }
                        if (num4 == 2)
                        {
                            Main.tile[i - 1, j - 1].frameX = 44;
                            Main.tile[i - 1, j - 1].frameY = 66;
                        }
                    }
                    num4 = WorldGen.genRand.Next(3);
                    switch (num6)
                    {
                        case 0:
                            if (num4 == 0) // 132 154 176
                            {
                                Main.tile[i, j - 1].frameX = 88;
                                Main.tile[i, j - 1].frameY = 110;
                            }
                            if (num4 == 1)
                            {
                                Main.tile[i, j - 1].frameX = 88;
                                Main.tile[i, j - 1].frameY = 88;
                            }
                            if (num4 == 2)
                            {
                                Main.tile[i, j - 1].frameX = 88;
                                Main.tile[i, j - 1].frameY = 66;
                            }
                            break;
                        case 1:
                            if (num4 == 0) // 132 154 176
                            {
                                Main.tile[i, j - 1].frameX = 0;
                                Main.tile[i, j - 1].frameY = 110;
                            }
                            if (num4 == 1)
                            {
                                Main.tile[i, j - 1].frameX = 0;
                                Main.tile[i, j - 1].frameY = 88;
                            }
                            if (num4 == 2)
                            {
                                Main.tile[i, j - 1].frameX = 0;
                                Main.tile[i, j - 1].frameY = 66;
                            }
                            break;
                        case 2:
                            if (num4 == 0) // 132 154 176
                            {
                                Main.tile[i, j - 1].frameX = 66;
                                Main.tile[i, j - 1].frameY = 110;
                            }
                            if (num4 == 1)
                            {
                                Main.tile[i, j - 1].frameX = 66;
                                Main.tile[i, j - 1].frameY = 88;
                            }
                            if (num4 == 2)
                            {
                                Main.tile[i, j - 1].frameX = 66;
                                Main.tile[i, j - 1].frameY = 66;
                            }
                            break;
                    }
                    if (WorldGen.genRand.Next(8) != 0)
                    {
                        num4 = WorldGen.genRand.Next(3);
                        if (num4 == 0) // 198 220 242
                        {
                            Main.tile[i, j - heightOfTree].frameX = 22;
                            Main.tile[i, j - heightOfTree].frameY = 44;
                        }
                        if (num4 == 1)
                        {
                            Main.tile[i, j - heightOfTree].frameX = 22;
                            Main.tile[i, j - heightOfTree].frameY = 22;
                        }
                        if (num4 == 2)
                        {
                            Main.tile[i, j - heightOfTree].frameX = 22;
                            Main.tile[i, j - heightOfTree].frameY = 0;
                        }
                    }
                    else
                    {
                        num4 = WorldGen.genRand.Next(3);
                        if (num4 == 0) // 198 220 242
                        {
                            Main.tile[i, j - heightOfTree].frameX = 0;
                            Main.tile[i, j - heightOfTree].frameY = 44;
                        }
                        if (num4 == 1)
                        {
                            Main.tile[i, j - heightOfTree].frameX = 0;
                            Main.tile[i, j - heightOfTree].frameY = 22;
                        }
                        if (num4 == 2)
                        {
                            Main.tile[i, j - heightOfTree].frameX = 0;
                            Main.tile[i, j - heightOfTree].frameY = 0;
                        }
                    }
                    WorldGen.RangeFrame(i - 2, j + heightOfTree - 1, i + 2, j + 1);
                    if (Main.netMode == NetmodeID.Server)
                    {
                        NetMessage.SendTileSquare(-1, i, (int)((double)j - (double)heightOfTree * 0.5), heightOfTree + 1);
                    }
                    return true;
                }
            }
            return false;
        }

        public void DropComet(int tile)
        {
            var flag = true;
            var num = 0;
            if (Main.netMode == NetmodeID.MultiplayerClient)
            {
                return;
            }
            for (var i = 0; i < 255; i++)
            {
                if (Main.player[i].active)
                {
                    flag = false;
                    break;
                }
            }
            var num2 = 0;
            float num3 = Main.maxTilesX / 4200;
            var num4 = (int)(400f * num3);
            for (var j = 5; j < Main.maxTilesX - 5; j++)
            {
                var num5 = 5;
                while (num5 < Main.worldSurface)
                {
                    if (Main.tile[j, num5].active() && Main.tile[j, num5].type == tile)
                    {
                        num2++;
                        if (num2 > num4)
                        {
                            return;
                        }
                    }
                    num5++;
                }
            }
            while (!flag)
            {
                var num6 = Main.maxTilesX * 0.08f;
                var num7 = Main.rand.Next(50, Main.maxTilesX - 50);
                while (num7 > Main.spawnTileX - num6 && num7 < Main.spawnTileX + num6)
                {
                    num7 = Main.rand.Next(50, Main.maxTilesX - 50);
                }
                for (var k = Main.rand.Next(100); k < Main.maxTilesY; k++)
                {
                    if (Main.tile[num7, k].active() && Main.tileSolid[Main.tile[num7, k].type])
                    {
                        flag = Comet(num7, k, tile);
                        break;
                    }
                }
                num++;
                if (num >= 100)
                {
                    return;
                }
            }
        }

        public bool Comet(int i, int j, int tile)
        {
            if (i < 50 || i > Main.maxTilesX - 50)
            {
                return false;
            }
            if (j < 50 || j > Main.maxTilesY - 50)
            {
                return false;
            }
            var num = 25;
            var rectangle = new Rectangle((i - num) * 16, (j - num) * 16, num * 2 * 16, num * 2 * 16);
            for (var k = 0; k < 255; k++)
            {
                if (Main.player[k].active)
                {
                    var value = new Rectangle((int)(Main.player[k].position.X + Main.player[k].width / 2 - NPC.sWidth / 2 - NPC.safeRangeX), (int)(Main.player[k].position.Y + Main.player[k].height / 2 - NPC.sHeight / 2 - NPC.safeRangeY), NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
                    if (rectangle.Intersects(value))
                    {
                        return false;
                    }
                }
            }
            for (var l = 0; l < 200; l++)
            {
                if (Main.npc[l].active)
                {
                    var value2 = new Rectangle((int)Main.npc[l].position.X, (int)Main.npc[l].position.Y, Main.npc[l].width, Main.npc[l].height);
                    if (rectangle.Intersects(value2))
                    {
                        return false;
                    }
                }
            }
            for (var m = i - num; m < i + num; m++)
            {
                for (var n = j - num; n < j + num; n++)
                {
                    if (Main.tile[m, n].active() && Main.tile[m, n].type == 21 || Main.tile[m, n].type == TileID.Containers2)
                    {
                        return false;
                    }
                }
            }
            stopCometDrops = true;
            num = 15;
            for (var num2 = i - num; num2 < i + num; num2++)
            {
                for (var num3 = j - num; num3 < j + num; num3++)
                {
                    if (num3 > j + Main.rand.Next(-2, 3) - 5 && Math.Abs(i - num2) + Math.Abs(j - num3) < num * 1.5 + Main.rand.Next(-5, 5))
                    {
                        if (!Main.tileSolid[Main.tile[num2, num3].type])
                        {
                            Main.tile[num2, num3].active(false);
                        }
                        Main.tile[num2, num3].type = (ushort)tile;
                    }
                }
            }
            num = 10;
            for (var num4 = i - num; num4 < i + num; num4++)
            {
                for (var num5 = j - num; num5 < j + num; num5++)
                {
                    if (num5 > j + Main.rand.Next(-2, 3) - 5 && Math.Abs(i - num4) + Math.Abs(j - num5) < num + Main.rand.Next(-3, 4))
                    {
                        Main.tile[num4, num5].active(false);
                    }
                }
            }
            num = 16;
            for (var num6 = i - num; num6 < i + num; num6++)
            {
                for (var num7 = j - num; num7 < j + num; num7++)
                {
                    if (Main.tile[num6, num7].type == 5 || Main.tile[num6, num7].type == 32)
                    {
                        WorldGen.KillTile(num6, num7, false, false, false);
                    }
                    WorldGen.SquareTileFrame(num6, num7, true);
                    WorldGen.SquareWallFrame(num6, num7, true);
                }
            }
            num = 23;
            for (var num8 = i - num; num8 < i + num; num8++)
            {
                for (var num9 = j - num; num9 < j + num; num9++)
                {
                    if (Main.tile[num8, num9].active() && Main.rand.Next(10) == 0 && Math.Abs(i - num8) + Math.Abs(j - num9) < num * 1.3)
                    {
                        if (Main.tile[num8, num9].type == 5 || Main.tile[num8, num9].type == 32)
                        {
                            WorldGen.KillTile(num8, num9, false, false, false);
                        }
                        Main.tile[num8, num9].type = (ushort)tile;
                        WorldGen.SquareTileFrame(num8, num9, true);
                    }
                }
            }
            stopCometDrops = false;
            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                Main.NewText("A comet has struck ground!", 0, 201, 190, false);
            }
            else if (Main.netMode == NetmodeID.Server)
            {
                NetMessage.BroadcastChatMessage(NetworkText.FromLiteral("A comet has struck ground!"), new Color(0, 201, 190));
            }
            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                NetMessage.SendTileSquare(-1, i, j, 30);
            }
            return true;
        }

        public static void InitiateSuperHardmode()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(shmCallback), 1);
        }
        public static void shmCallback(object threadContext)
        {
            if (ExxoAvalonOrigins.superHardmode) return;
            GenerateSHMOres();
            ExxoAvalonOrigins.superHardmode = true;
            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                Main.NewText("The ancient souls have been disturbed...", 255, 60, 0);
                Main.NewText("The heavens above are rumbling...", 50, 255, 130);
                Main.NewText("Your world has been blessed with the elements!", 0, 255, 0);
            }
            else if (Main.netMode == NetmodeID.Server)
            {
                NetMessage.BroadcastChatMessage(NetworkText.FromLiteral("The ancient souls have been disturbed..."), new Color(255, 60, 0));
                NetMessage.BroadcastChatMessage(NetworkText.FromLiteral("The heavens above are rumbling..."), new Color(50, 255, 130));
                NetMessage.BroadcastChatMessage(NetworkText.FromLiteral("Your world has been blessed with the elements!"), new Color(0, 255, 0));
            }
            if (Main.netMode == NetmodeID.Server)
            {
                Netplay.ResetSections();
            }
        }
        public static void GenerateSHMOres()
        {
            if (Main.rand == null)
            {
                Main.rand = new UnifiedRandom((int)DateTime.Now.Ticks);
            }
            // oblivion ore
            for (int a = 0; a < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00012); a++)
            {
                int x = Main.rand.Next(100, Main.maxTilesX - 100);
                int y = Main.rand.Next((int)Main.rockLayer, Main.maxTilesY - 200);
                WorldGen.OreRunner(x, y, Main.rand.Next(3, 6), Main.rand.Next(2, 7), (ushort)ModContent.TileType<Tiles.OblivionOre>());
            }
            // opals
            for (int a = 0; a < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00012); a++)
            {
                int x = Main.rand.Next(100, Main.maxTilesX - 100);
                int y = Main.rand.Next((int)Main.rockLayer, Main.maxTilesY - 200);
                WorldGen.OreRunner(x, y, Main.rand.Next(4, 7), Main.rand.Next(1, 4), (ushort)ModContent.TileType<Tiles.Opal>());
            }
            // onyx
            for (int a = 0; a < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00012); a++)
            {
                int x = Main.rand.Next(100, Main.maxTilesX - 100);
                int y = Main.rand.Next((int)Main.rockLayer, Main.maxTilesY - 200);
                WorldGen.OreRunner(x, y, Main.rand.Next(3, 5), Main.rand.Next(1, 4), (ushort)ModContent.TileType<Tiles.Onyx>());
            }
            // kunzite
            for (int a = 0; a < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00012); a++)
            {
                int x = Main.rand.Next(100, Main.maxTilesX - 100);
                int y = Main.rand.Next((int)Main.rockLayer, Main.maxTilesY - 200);
                WorldGen.OreRunner(x, y, Main.rand.Next(3, 5), Main.rand.Next(1, 4), (ushort)ModContent.TileType<Tiles.Kunzite>());
            }
            // primordial ore
            for (int a = 0; a < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00012); a++)
            {
                int x = Main.rand.Next(100, Main.maxTilesX - 100);
                int y = Main.rand.Next((int)Main.rockLayer, Main.maxTilesY - 200);
                WorldGen.OreRunner(x, y, Main.rand.Next(3, 6), Main.rand.Next(5, 8), (ushort)ModContent.TileType<Tiles.PrimordialOre>());
            }
        }
        public void MakeOblivionOre(NPC npc1, NPC npc2, string text, int radius)
        {
            if (Collision.CheckAABBvAABBCollision(npc1.Center, new Vector2(npc1.width, npc1.height), npc2.Center, new Vector2(npc2.width, npc2.height)))
            {
                Utils.MakeCircle((int)(npc1.position.X / 16f), (int)(npc1.position.Y / 16f), radius, ModContent.TileType<Tiles.OblivionOre>());
                npc1.life = 0;
                npc1.NPCLoot();
                npc1.active = false;
                Main.PlaySound(npc1.DeathSound.SoundId, (int)npc1.position.X, (int)npc1.position.Y);
                npc2.life = 0;
                npc2.NPCLoot();
                npc2.active = false;
                Main.PlaySound(npc2.DeathSound.SoundId, (int)npc2.position.X, (int)npc2.position.Y);
                Color color = new Color(135, 78, 0);
                if (Main.netMode == NetmodeID.SinglePlayer)
                {
                    Main.NewText(text, color);
                }
                else if (Main.netMode == NetmodeID.Server)
                {
                    NetMessage.BroadcastChatMessage(NetworkText.FromLiteral(text), color);
                }
            }
        }
        public override TagCompound Save()
        {
            var toSave = new TagCompound
            {
                { "ExxoAvalonOrigins:LastOpenedVersion", ExxoAvalonOrigins.version.ToString() },
                { "ExxoAvalonOrigins:SuperHardMode", ExxoAvalonOrigins.superHardmode },
                { "ExxoAvalonOrigins:DownedBacteriumPrime", downedBacteriumPrime },
                { "ExxoAvalonOrigins:DownedDesertBeak", downedDesertBeak },
                { "ExxoAvalonOrigins:DownedPhantasm", downedPhantasm },
                { "ExxoAvalonOrigins:DownedDragonLord", downedDragonLord },
                { "ExxoAvalonOrigins:DownedMechasting", downedMechasting },
                { "ExxoAvalonOrigins:DownedOblivion", downedOblivion },
                { "ExxoAvalonOrigins:LibraryofKnowledge", LoK },
                { "ExxoAvalonOrigins:Contagion", contaigon },
                { "ExxoAvalonOrigins:DungeonSide", dungeonSide },
                { "ExxoAvalonOrigins:DungeonX", ExxoAvalonOrigins.dungeonEx },
                { "ExxoAvalonOrigins:SHMOreTier1", shmOreTier1 },
                { "ExxoAvalonOrigins:SHMOreTier2", shmOreTier2 },
                { "ExxoAvalonOrigins:OsmiumOre", (int)rhodiumOre },
                { "ExxoAvalonOrigins:HallowAltarCount", hallowAltarCount },
                { "ExxoAvalonOrigins:JungleType", (int)jungleMenuSelection },
                { "ExxoAvalonOrigins:WorldDarkMatterTiles", WorldDarkMatterTiles },
            };

            // Update config cache values on save world
            ExxoAvalonOriginsConfig config = ModContent.GetInstance<ExxoAvalonOriginsConfig>();
            var tempDict = config.GetWorldData();
            ExxoAvalonOriginsConfig.WorldDataValues worldData;

            worldData.contagion = contaigon;
            worldData.jungleType = (int)jungleMenuSelection;

            string path = Path.ChangeExtension(Main.worldPathName, ".twld");
            tempDict[path] = worldData;
            config.SetWorldData(tempDict);

            ExxoAvalonOriginsConfig.Save(config);

            return toSave;
        }

        public override void Load(TagCompound tag)
        {
            if (tag.ContainsKey("ExxoAvalonOrigins:LastOpenedVersion"))
            {
                ExxoAvalonOrigins.lastOpenedVersion = new Version(tag["ExxoAvalonOrigins:LastOpenedVersion"].ToString());
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:SuperHardMode"))
            {
                ExxoAvalonOrigins.superHardmode = tag.Get<bool>("ExxoAvalonOrigins:SuperHardMode");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DownedBacteriumPrime"))
            {
                downedBacteriumPrime = tag.Get<bool>("ExxoAvalonOrigins:DownedBacteriumPrime");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DownedDesertBeak"))
            {
                downedDesertBeak = tag.Get<bool>("ExxoAvalonOrigins:DownedDesertBeak");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DownedPhantasm"))
            {
                downedPhantasm = tag.Get<bool>("ExxoAvalonOrigins:DownedPhantasm");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DownedDragonLord"))
            {
                downedDragonLord = tag.Get<bool>("ExxoAvalonOrigins:DownedDragonLord");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DownedMechasting"))
            {
                downedMechasting = tag.Get<bool>("ExxoAvalonOrigins:DownedMechasting");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DownedOblivion"))
            {
                downedOblivion = tag.Get<bool>("ExxoAvalonOrigins:DownedOblivion");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:LibraryofKnowledge"))
            {
                LoK = tag.Get<Vector2>("ExxoAvalonOrigins:LibraryofKnowledge");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:Contagion"))
            {
                contaigon = tag.Get<bool>("ExxoAvalonOrigins:Contagion");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:JungleType"))
            {
                jungleMenuSelection = (JungleVariant)tag.GetAsInt("ExxoAvalonOrigins:JungleType");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DungeonSide"))
            {
                dungeonSide = tag.GetAsInt("ExxoAvalonOrigins:DungeonSide");
            }
            else
            {
                dungeonSide = -1;
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:DungeonX"))
            {
                ExxoAvalonOrigins.dungeonEx = tag.GetAsInt("ExxoAvalonOrigins:DungeonX");
            }
            else
            {
                ExxoAvalonOrigins.dungeonEx = dungeonSide == -1 ? Main.maxTilesX / 3 : Main.maxTilesX - Main.maxTilesX / 3;
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:SHMOreTier1"))
            {
                shmOreTier1 = tag.GetAsInt("ExxoAvalonOrigins:SHMOreTier1");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:SHMOreTier2"))
            {
                shmOreTier2 = tag.GetAsInt("ExxoAvalonOrigins:SHMOreTier2");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:OsmiumOre"))
            {
                rhodiumOre = (RhodiumVariant)tag.GetAsInt("ExxoAvalonOrigins:OsmiumOre");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:HallowAltarCount"))
            {
                hallowAltarCount = tag.GetAsInt("ExxoAvalonOrigins:HallowAltarCount");
            }
            if (tag.ContainsKey("ExxoAvalonOrigins:WorldDarkMatterTiles"))
            {
                WorldDarkMatterTiles = tag.GetAsInt("ExxoAvalonOrigins:WorldDarkMatterTiles");
                if (WorldDarkMatterTiles < 0)
                {
                    WorldDarkMatterTiles = 0;
                }
            }
        }
    }
}