﻿using Microsoft.Xna.Framework;
    public class AdvNightOwl : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Night Owl");
            Description.SetDefault("Increased night vision");
        }

        public override void Update(Player player, ref int k)
        {
            player.nightVision = true;
        }
    }