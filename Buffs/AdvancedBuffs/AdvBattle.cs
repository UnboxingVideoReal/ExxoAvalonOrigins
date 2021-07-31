﻿using Microsoft.Xna.Framework;
    public class AdvBattle : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Battle");
            Description.SetDefault("Increased enemy spawn rate");
        }

        public override void Update(Player player, ref int k)
        {
            player.enemySpawns = true;
        }
    }