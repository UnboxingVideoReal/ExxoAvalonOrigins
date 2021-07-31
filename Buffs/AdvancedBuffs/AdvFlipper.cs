﻿using Microsoft.Xna.Framework;
    public class AdvFlipper : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Flipper");
            Description.SetDefault("Move like normal in water");
        }

        public override void Update(Player player, ref int k)
        {
            player.accFlipper = true;
        }
    }