﻿using Microsoft.Xna.Framework;
    public class AdvObsidianSkin : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Obsidian Skin");
            Description.SetDefault("Immune to lava");
        }

        public override void Update(Player player, ref int k)
        {
            player.lavaImmune = true;
        }
    }