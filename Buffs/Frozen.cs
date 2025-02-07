﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;


namespace ExxoAvalonOrigins.Buffs
{
    public class Frozen : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Frozen");
            Description.SetDefault("'I can't move!'");
            Main.debuff[Type] = true;
            canBeCleared = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<ExxoAvalonOriginsModPlayer>().frozen = true;

            player.controlUp = false;
            player.controlDown = false;
            player.controlLeft = false;
            player.controlRight = false;
            player.controlJump = false;
            player.noItems = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.velocity.X = 0;
            npc.velocity.Y = 0;
        }
    }
}
