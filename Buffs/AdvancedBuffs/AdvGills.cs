﻿using Microsoft.Xna.Framework;
    public class AdvGills : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Gills");
            Description.SetDefault("Breate water instead of air");
        }

        public override void Update(Player player, ref int k)
        {
            player.gills = true;
        }
    }