﻿using Microsoft.Xna.Framework;
    public class TuhrtlBrickWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            drop = mod.ItemType("TuhrtlBrickWall");
            dustType = 1;
        }
    }