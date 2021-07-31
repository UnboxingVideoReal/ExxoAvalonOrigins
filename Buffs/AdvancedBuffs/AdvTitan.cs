﻿using Microsoft.Xna.Framework;
    public class AdvTitan : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Titan");
            Description.SetDefault("Increases knockback");
        }

        public override void Update(Player player, ref int k)
        {
            player.kbBuff = true;
        }
    }