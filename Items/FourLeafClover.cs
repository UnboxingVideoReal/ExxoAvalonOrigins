﻿using Microsoft.Xna.Framework;
    class FourLeafClover : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Four Leaf Clover");
            Tooltip.SetDefault("You are very lucky to have found this!");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/FourLeafClover");
            item.rare = 7;
            item.width = dims.Width;
            item.maxStack = 999;
            item.value = Item.sellPrice(5);
            item.height = dims.Height;
        }
    }