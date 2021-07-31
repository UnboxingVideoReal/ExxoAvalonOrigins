﻿using Microsoft.Xna.Framework;
    public class AdvArchery : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Archery");
            Description.SetDefault("20% increased arrow damage and speed");
        }

        public override void Update(Player player, ref int k)
        {
            player.archery = true;
        }
    }