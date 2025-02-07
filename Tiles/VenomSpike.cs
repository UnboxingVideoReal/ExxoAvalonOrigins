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
using Terraria.Localization;

namespace ExxoAvalonOrigins.Tiles
{
    public class VenomSpike : ModTile
    {
        public override void SetDefaults()
        {
            AddMapEntry(new Color(132, 65, 172), LanguageManager.Instance.GetText("Venom Spike"));
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("VenomSpike");
            soundType = SoundID.Tink;
            soundStyle = 1;
            dustType = DustID.PurpleTorch;
        }
        public override bool Slope(int i, int j)
        {
            return false;
        }
    }
}