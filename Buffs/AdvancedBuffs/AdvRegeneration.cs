﻿using Microsoft.Xna.Framework;
    public class AdvRegeneration : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Regeneration");
            Description.SetDefault("Provides life regeneration");
        }

        public override void Update(Player player, ref int k)
        {
            player.lifeRegen += 4;
        }
    }