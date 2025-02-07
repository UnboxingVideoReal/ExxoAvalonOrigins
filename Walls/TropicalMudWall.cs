﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Walls
{
    public class TropicalMudWall : ModWall
    {
        public override void SetDefaults()
        {
            AddMapEntry(new Color(67, 32, 20));
			dustType = ModContent.DustType<Dusts.TropicalMudDust>();
        }
    }
}