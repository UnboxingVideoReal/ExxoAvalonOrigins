﻿using Microsoft.Xna.Framework;
    public class AdvFeatherfall : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Featherfall");
            Description.SetDefault("Press UP or DOWN to control speed of descent");
        }

        public override void Update(Player player, ref int k)
        {
            player.slowFall = true;
        }
    }