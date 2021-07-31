﻿using Microsoft.Xna.Framework;
    public class AdvSonar : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Sonar");
            Description.SetDefault("You can see what's biting your hook");
        }

        public override void Update(Player player, ref int k)
        {
            player.sonarPotion = true;
        }
    }