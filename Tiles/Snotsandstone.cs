﻿using Microsoft.Xna.Framework;
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
    public class Snotsandstone : ModTile
    {
        public override void SetDefaults()
        {
            AddMapEntry(new Color(91, 109, 86));
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMerge[Type][TileID.Sandstone] = true;
            Main.tileMerge[TileID.Sandstone][Type] = true;
            Main.tileMerge[Type][TileID.HardenedSand] = true;
            Main.tileMerge[TileID.HardenedSand][Type] = true;
            Main.tileMerge[Type][ModContent.TileType<HardenedSnotsand>()] = true;
            Main.tileMerge[ModContent.TileType<HardenedSnotsand>()][Type] = true;
            Main.tileMerge[ModContent.TileType<Snotsand>()][Type] = true;
            Main.tileMerge[Type][ModContent.TileType<Snotsand>()] = true;
            TileID.Sets.Conversion.Sandstone[Type] = true;
            drop = mod.ItemType("SnotsandstoneBlock");
            dustType = DustID.ScourgeOfTheCorruptor;
        }
    }
}