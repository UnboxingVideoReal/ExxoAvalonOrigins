﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;

namespace ExxoAvalonOrigins.Buffs.AdvancedBuffs
{
    public class AdvVision : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Vision");
            Description.SetDefault("Open caves light up");
        }

        public override void Update(Player player, ref int k)
        {
            player.GetModPlayer<ExxoAvalonOriginsModPlayer>().vision = true;
        }
    }
}